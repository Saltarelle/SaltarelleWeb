using System.Collections.Generic;
using ICSharpCode.NRefactory.CSharp;

namespace Generator
{
    internal class EnumMemberDeclarationComparer : IComparer<EnumMemberDeclaration>
    {
        public bool ByValue { get; set; }

        public EnumMemberDeclarationComparer(bool byValue)
        {
            this.ByValue = byValue;
        }

        public int Compare(EnumMemberDeclaration a, EnumMemberDeclaration b)
        {
            if (ByValue)
            {
                var xa = a.Initializer as PrimitiveExpression;
                var xb = b.Initializer as PrimitiveExpression;

                var comparer = Comparer<object>.Default;

                if (xa == null || xb == null)
                {
                    return comparer.Compare(xa, xb);
                }

                return comparer.Compare(xa.Value, xb.Value);
            }

            var lowest = "None";
            var ba = a.Name == lowest;
            var bb = b.Name == lowest;

            if (ba == bb)
            {
                return string.Compare(a.Name, b.Name);
            }

            if (ba)
            {
                return -1;
            }

            return 1;
        }
    }
}
