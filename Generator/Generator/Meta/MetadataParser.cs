using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime;

namespace Generator.Meta
{
    public class MetadataParser
    {
        public static Tuple<Metadata, List<string>> Parse(string metadata)
        {
            var lex = new MetadataParserImpl.MetadataLexer(new ANTLRStringStream(metadata));
            var tokens = new CommonTokenStream(lex);
            var parser = new MetadataParserImpl.MetadataParser(tokens);

            var parsed = parser.file();

            if (lex.Errors.Count > 0 || parser.Errors.Count > 0)
                return Tuple.Create((Metadata)null, lex.Errors.Concat(parser.Errors).ToList());

            var errors = new List<string>();
            foreach (var item in parsed.Item1)
            {
                if (string.IsNullOrEmpty(item.Namespace) && item.Generate)
                    errors.Add("Must specify namespace for the type `" + item.TypeName + "'");
            }

            return Tuple.Create(errors.Count == 0 ? new Metadata(parsed.Item1, parsed.Item2) : null, errors);
        }
    }
}
