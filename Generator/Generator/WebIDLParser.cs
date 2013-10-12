using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Generator.AstNodes;

namespace Generator {
	public static class WebIDLParser {
		public static Definitions Parse(TextReader source) {
			var lex = new ParserImpl.WebIDLLexer(new ANTLRReaderStream(source));
			var tokens = new CommonTokenStream(lex);
			var parser = new ParserImpl.WebIDLParser(tokens);

			return parser.definitions();
		}
	}
}
