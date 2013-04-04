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

        public Uint8Array(uint length)
        {
        }

        public Uint8Array(Uint8Array array)
        {
        }

        public Uint8Array(CSHARPTYPE[] values)
        {
        }

        public Uint8Array(ArrayBuffer buffer)
        {
        }

        public Uint8Array(ArrayBuffer buffer, uint byteOffset)
        {
        }

        public Uint8Array(ArrayBuffer buffer, uint byteOffset, uint length)
        {
        }

        public static uint BytesPerElement
        {
            [InlineCode("Uint8Array.BYTES_PER_ELEMENT")]
            get;
            private set;
        }

        public uint Length { get; private set; }

        [IntrinsicProperty]
        public CSHARPTYPE this[uint index]
        {
            get { return default(CSHARPTYPE); }
            set { }
        }

        public void Set(Uint8Array array)
        {
        }

        public void Set(Uint8Array array, uint offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, uint offset)
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
