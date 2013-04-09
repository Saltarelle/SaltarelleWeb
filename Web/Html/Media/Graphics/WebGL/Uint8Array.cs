// Uint8Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;
using CSHARPTYPE = System.Byte;

namespace System.Html.Media.Graphics.WebGL
{
    [IgnoreNamespace, Imported]
    public class Uint8Array : ArrayBufferView
    {
        protected Uint8Array()
        {
        }

        [ScriptName("")]
        public Uint8Array(int length)
        {
        }

        [ScriptName("")]
        public Uint8Array(Uint8Array array)
        {
        }

        [ScriptName("")]
        public Uint8Array(CSHARPTYPE[] values)
        {
        }

        [ScriptName("")]
        public Uint8Array(ArrayBuffer buffer)
        {
        }

        [ScriptName("")]
        public Uint8Array(ArrayBuffer buffer, int byteOffset)
        {
        }

        [ScriptName("")]
        public Uint8Array(ArrayBuffer buffer, int byteOffset, int length)
        {
        }

        public static int BytesPerElement
        {
            [InlineCode("Uint8Array.BYTES_PER_ELEMENT")]
            get;
            private set;
        }

        public int Length { get; private set; }

        [IntrinsicProperty]
        public CSHARPTYPE this[int index]
        {
            get { return default(CSHARPTYPE); }
            set { }
        }

        public void Set(Uint8Array array)
        {
        }

        public void Set(Uint8Array array, int offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, int offset)
        {
        }

        public Uint8Array Subarray(int begin)
        {
            return null;
        }

        public Uint8Array Subarray(int begin, int end)
        {
            return null;
        }
    }
}
