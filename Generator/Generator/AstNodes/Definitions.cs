using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.ExtensionMethods;

namespace Generator.AstNodes
{
    public class Definitions
    {
        private Definitions() { }

        public IReadOnlyList<Definition> Items { get; private set; }

        public Definitions(IEnumerable<Definition> items)
        {
            this.Items = items.AsReadOnlySafe();
        }
    }
}
