using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Mono.Options;

namespace Generator {
	class Program {
		public class Arguments {
			public string OutputDirectory { get; set; }
			public List<string> Sources { get; private set; }

			public Arguments() {
				Sources = new List<string>();
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
			            .Where(arg => !string.IsNullOrEmpty(arg));
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
				var parsedArgs = new Arguments();
				var opts = new OptionSet {
					{ "?|help", v => showHelp = true },
					{ "o|out=", v => parsedArgs.OutputDirectory = v },
				};

				var sources = opts.Parse(actualArgs);

				if (showHelp) {
					Console.WriteLine("Web source generator");
					Console.WriteLine("Usage: " + Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location) + " options source-files");
					Console.WriteLine();
					Console.WriteLine("Options:" );
					Console.WriteLine("    --help, -?   Show this message." );
					Console.WriteLine("    --out, -o    Specifies the output directory (mandatory)." );
					Console.WriteLine("    @file        Treat the file as if its entire content were passed on the command line." );
				}
				else {
					if (string.IsNullOrEmpty(parsedArgs.OutputDirectory)) {
						throw new OptionException("The output directory (-o) must be specified (use the option -? for help).", "out");
					}

					try {
						parsedArgs.OutputDirectory = Path.GetFullPath(parsedArgs.OutputDirectory);
						Directory.CreateDirectory(parsedArgs.OutputDirectory);
					}
					catch (IOException ex) {
						throw new OptionException("Error creating output directory + " + parsedArgs.OutputDirectory + ": " + ex.Message, "out");
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

					Process(parsedArgs);
				}
			}
			catch (OptionException ex) {
				Console.WriteLine(ex.Message);
				return 1;
			}
			return 0;
		}

		private static void Process(Arguments args) {
			Console.WriteLine("Output: " + args.OutputDirectory);
			foreach (var s in args.Sources)
				Console.WriteLine("Source: " + s);
		}
	}
}
