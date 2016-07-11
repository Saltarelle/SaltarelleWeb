using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.AstNodes
{
    [Flags]
    public enum AttributeQualifiers
    {
        None = 0,
        Stringifier = 1,
        Static = 2,
        ReadOnly = 4,
        Inherit = 8,
    }
}
