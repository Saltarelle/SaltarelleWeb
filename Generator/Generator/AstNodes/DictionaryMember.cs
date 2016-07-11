using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.ExtensionMethods;

namespace Generator.AstNodes
{
    public class DictionaryMember
    {
        private DictionaryMember() { }

        public WebIDLType Type { get; private set; }
        public string Name { get; private set; }
        public Value Default { get; private set; }
        public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

        public static DictionaryMember Create(WebIDLType type, string name, Value @default, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return new DictionaryMember { Type = type, Name = name, Default = @default, ExtendedAttributes = extendedAttributes.AsReadOnlySafe() };
        }
    }
}
