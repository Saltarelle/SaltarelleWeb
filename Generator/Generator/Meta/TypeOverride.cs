using ICSharpCode.NRefactory.CSharp;

namespace Generator.Meta
{
    public class TypeOverride
    {
        public string Identifier { get; private set; }
        public AstType NewType { get; private set; }

        public TypeOverride(string identifier, AstType newType)
        {
            Identifier = identifier;
            NewType = newType;
        }
    }
}