// Int32Array.cs
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
    public class Int32Array : ArrayBufferView
    {
        public Int32Array(uint length)
        {
        }

        public Int32Array(Int32Array array)
        {
        }

        public Int32Array(CSHARPTYPE[] values)
        {
        }

        public Int32Array(ArrayBuffer buffer)
        {
        }

        public Int32Array(ArrayBuffer buffer, uint byteOffset)
        {
        }

        public Int32Array(ArrayBuffer buffer, uint byteOffset, uint length)
        {
        }

        public static uint BytesPerElement
        {
            [InlineCode("Int32Array.BYTES_PER_ELEMENT")]
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

        public void Set(Int32Array array)
        {
        }

        public void Set(Int32Array array, uint offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, uint offset)
        {
        }

        public Int32Array Subarray(int begin)
        {
            return null;
        }

        public Int32Array Subarray(int begin, int end)
        {
            return null;
        }
    }
}
