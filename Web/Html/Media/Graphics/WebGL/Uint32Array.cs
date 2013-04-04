// Uint32Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;
using CSHARPTYPE = System.Int32;

namespace System.Html.Media.Graphics.WebGL
{
    [IgnoreNamespace, Imported]
    public class Uint32Array : ArrayBufferView
    {
        public Uint32Array(int length)
        {
        }

        public Uint32Array(Uint32Array array)
        {
        }

        public Uint32Array(CSHARPTYPE[] values)
        {
        }

        public Uint32Array(ArrayBuffer buffer)
        {
        }

        public Uint32Array(ArrayBuffer buffer, int byteOffset)
        {
        }

        public Uint32Array(ArrayBuffer buffer, int byteOffset, int length)
        {
        }

        public static int BytesPerElement
        {
            [InlineCode("Uint32Array.BYTES_PER_ELEMENT")]
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

        public void Set(Uint32Array array)
        {
        }

        public void Set(Uint32Array array, int offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, int offset)
        {
        }

        public Uint32Array Subarray(int begin)
        {
            return null;
        }

        public Uint32Array Subarray(int begin, int end)
        {
            return null;
        }
    }
}
