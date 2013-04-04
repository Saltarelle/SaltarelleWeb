using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Net
{
    [IgnoreNamespace, Imported]
    public class Blob
    {
        [ScriptName("")]
        public Blob()
        {
        }

        [ScriptName("")]
        public Blob(Array parts)
        {
        }

        [ScriptName("")]
        public Blob(Array parts, BlobPropertyBag properties)
        {
        }

        [IntrinsicProperty]
        public ulong Size { get; private set; }

        [IntrinsicProperty]
        public string Type { get; private set; }

        public Blob Slice()
        {
            return null;
        }

        public Blob Slice(long start)
        {
            return null;
        }

        public Blob Slice(long start, long end)
        {
            return null;
        }

        public Blob Slice(long start, long end, string contentType)
        {
            return null;
        }
    }
}
