using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime;
using Generator.AstNodes;
using Generator.Meta;
using ICSharpCode.NRefactory.Utils;
using Mono.Options;

namespace Generator {
	static class Program {
		public class Arguments {
			public string OutputDirectory { get; set; }
			public List<string> Sources { get; private set; }
			public List<string> RootNamespaces { get; private set; }
			public string Metadata { get; set; }

			public Arguments() {
				Sources = new List<string>();
				RootNamespaces = new List<string>();
			}
		}

		public static IEnumerable<string> Split(string str, Func<char, bool> controller) {
			int nextPiece = 0;

			for (int c = 0; c < str.Length; c++) {
				if (controller(str[c])) {
					yield return str.Substring(nextPiece, c - nextPiece);
					nextPiece = c + 1;
				}
			}
			yield return str.Substring(nextPiece);
		}

		public static string TrimMatchingQuotes(string input, char quote) {
			if ((input.Length >= 2) && (input[0] == quote) && (input[input.Length - 1] == quote))
				return input.Substring(1, input.Length - 2);
			return input;
		}

		public static IEnumerable<string> SplitCommandLine(string commandLine) {
			bool inQuotes = false;
		
			return Split(commandLine, c => {
			                                   if (c == '\"')
			                                       inQuotes = !inQuotes;
			                                   return !inQuotes && c == ' ';
			                               })
			            .Select(arg => TrimMatchingQuotes(arg.Trim(), '\"'))
			            .Where(arg => !String.IsNullOrEmpty(arg));
		}

		static int Main(string[] args) {
			try {
				var actualArgs = new List<string>();
				foreach (var arg in args) {
					if (arg.Length > 0 && arg[0] == '@') {
						string content;
						string filename = arg.Substring(1);
						try {
							filename = Path.GetFullPath(filename);
							content = File.ReadAllText(filename);
						}
						catch (IOException ex) {
							throw new OptionException("Error reading parameter file " + filename + ": " + ex.Message, "@");
						}

						actualArgs.AddRange(SplitCommandLine(content));
					}
					else {
						actualArgs.Add(arg);
					}
				}

				bool showHelp = actualArgs.Count == 0;
				var metadataFiles = new List<string>();
				var parsedArgs = new Arguments();
				var opts = new OptionSet {
					{ "?|help", v => showHelp = true },
					{ "o|out=", v => parsedArgs.OutputDirectory = v },
					{ "r|root=", v => parsedArgs.RootNamespaces.Add(v) },
					{ "m|meta=", v => metadataFiles.Add(v) },
				};

				var sources = opts.Parse(actualArgs);

				if (showHelp) {
					Console.WriteLine("Web source generator");
					Console.WriteLine("Usage: " + Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location) + " options source-files");
					Console.WriteLine();
					Console.WriteLine("Options:" );
					Console.WriteLine("    --help, -?  Show this message." );
					Console.WriteLine("    --meta, -m  Use the specified metadata file (mandatory, can be more than one).");
					Console.WriteLine("    --out, -o   Specifies the output directory (mandatory).");
					Console.WriteLine("    --root, -r  Adds a root namespace (a namespace that doesn't create a subdirectory).");
					Console.WriteLine("    @file       Treat the file as if its entire content were passed on the command line.");
				}
				else {
					if (String.IsNullOrEmpty(parsedArgs.OutputDirectory)) {
						throw new OptionException("The output directory (-o) must be specified (use the option -? for help).", "out");
					}

					try {
						parsedArgs.OutputDirectory = Path.GetFullPath(parsedArgs.OutputDirectory);
						Directory.CreateDirectory(parsedArgs.OutputDirectory);
					}
					catch (IOException ex) {
						throw new OptionException("Error creating output directory + " + parsedArgs.OutputDirectory + ": " + ex.Message, "out");
					}
	
					if (metadataFiles.Count == 0) {
						throw new OptionException("The metadata file (-m) must be specified (use the option -? for help).", "out");
					}

					var sb = new StringBuilder();
					foreach (var f in metadataFiles) {
						try {
							sb.AppendLine(File.ReadAllText(f));
						}
						catch (IOException ex) {
							throw new OptionException("Error reading file  + " + parsedArgs.OutputDirectory + ": " + ex.Message, "out");
						}
						parsedArgs.Metadata = sb.ToString();
					}

					foreach (var src in sources) {
						string filename = src;
						try {
							filename = Path.GetFullPath(filename);
							using (File.OpenRead(filename)) {
								// just verify that it is possible
							}
							parsedArgs.Sources.Add(filename);
						}
						catch (IOException ex) {
							throw new OptionException("The file " + filename + " could not be opened: " + ex.Message, "source");
						}
					}

					return Process(parsedArgs) ? 0 : 1;
				}
			}
			catch (OptionException ex) {
				Console.Error.WriteLine(ex.Message);
				return 1;
			}
			return 0;
		}

		private static Tuple<IReadOnlyList<Definitions>, IReadOnlyList<string>> Parse(IReadOnlyList<string> files) {
			var errors = new ConcurrentStack<string>();
			var allParts = new Definitions[files.Count];
			Parallel.ForEach(files, (file, _, i) => {
				try {
					allParts[i] = WebIDLParser.Parse(new StreamReader(file, Encoding.UTF8));
				}
				catch (IOException ex) {
					errors.Push("Error reading file " + file + ": " + ex.Message);
				}
				catch (RecognitionException ex) {
					errors.Push(file + "(" + ex.Line + ":" + ex.CharPositionInLine + "): " + ex.GetType().Name + ": " + ex.Message);
				}
			});
			return Tuple.Create<IReadOnlyList<Definitions>, IReadOnlyList<string>>(allParts, errors.ToList());
		}

		private static bool Process(Arguments args) {
			var parseResult = Parse(args.Sources);

			if (parseResult.Item2.Count > 0) {
				foreach (var e in parseResult.Item2)
					Console.Error.WriteLine(e);
				return false;
			}

			var metadata = MetadataParser.Parse(args.Metadata);
			if (metadata.Item2.Count > 0) {
				foreach (var e in metadata.Item2)
					Console.Error.WriteLine(e);
				return false;
			}

			var resolvedDefinitionsAndErrors = WebIDLResolver.Resolve(parseResult.Item1);
			if (resolvedDefinitionsAndErrors.Item2.Count > 0) {
				foreach (var e in resolvedDefinitionsAndErrors.Item2)
					Console.Error.WriteLine(e);
				return false;
			}

			var model = Converter.BuildCSharpModel(resolvedDefinitionsAndErrors.Item1, metadata.Item1);
			if (model.Item2.Count > 0) {
				foreach (var e in model.Item2)
					Console.Error.WriteLine(e);
				return false;
			}

			var generated = model.Item1.Select(t => Tuple.Create(t.Namespace, t.EntityDeclaration.Name, Formatter.Format(t))).ToList();

			var errors = new ConcurrentStack<string>();
			Parallel.ForEach(generated, c => {
				var rootLength = args.RootNamespaces.DefaultIfEmpty("").Max(r => c.Item1 == r ? c.Item1.Length : (c.Item1.StartsWith(r + ".") ? r.Length + 1 : 0));
				string filepath = Path.Combine(args.OutputDirectory, c.Item1.Substring(rootLength).Replace('.', Path.DirectorySeparatorChar), c.Item2 + ".cs");

				try {
					Directory.CreateDirectory(Path.GetDirectoryName(filepath));
					File.WriteAllText(filepath, c.Item3, Encoding.UTF8);
				}
				catch (IOException ex) {
					errors.Push("Error writing file " + filepath + ": " + ex.Message);
				}
			});
			if (errors.Count > 0) {
				foreach (var e in model.Item2)
					Console.Error.WriteLine(e);
				return false;
			}

			return true;
		}
	}
}
