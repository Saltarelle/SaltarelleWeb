using ICSharpCode.NRefactory.CSharp;

namespace Generator
{
    public class NamespacedEntityDeclaration
    {
        public string Namespace { get; private set; }
        public EntityDeclaration EntityDeclaration { get; private set; }

        public NamespacedEntityDeclaration(string @namespace, EntityDeclaration entityDeclaration)
        {
            Namespace = @namespace;
            EntityDeclaration = entityDeclaration;
        }
    }
}