using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Net
{
    [IgnoreNamespace, Imported]
    public class BlobPropertyBag
    {
        [InlineCode("{}")]
        public BlobPropertyBag()
        {
        }

        [InlineCode("{'type':{type}}")]
        public BlobPropertyBag(string type)
        {
        }

        [IntrinsicProperty]
        public string Type { get; set; }
    }
}
