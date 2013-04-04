// Float32Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;
using CSHARPTYPE = System.Single;

namespace System.Html.Media.Graphics.WebGL
{
    [IgnoreNamespace, Imported]
    public class Float32Array : ArrayBufferView
    {
        public Float32Array(uint length)
        {
        }

        public Float32Array(Float32Array array)
        {
        }

        public Float32Array(CSHARPTYPE[] values)
        {
        }

        public Float32Array(ArrayBuffer buffer)
        {
        }

        public Float32Array(ArrayBuffer buffer, uint byteOffset)
        {
        }

        public Float32Array(ArrayBuffer buffer, uint byteOffset, uint length)
        {
        }

        public static uint BytesPerElement
        {
            [InlineCode("Float32Array.BYTES_PER_ELEMENT")]
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

        public void Set(Float32Array array)
        {
        }

        public void Set(Float32Array array, uint offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, uint offset)
        {
        }

        public Float32Array Subarray(int begin)
        {
            return null;
        }

        public Float32Array Subarray(int begin, int end)
        {
            return null;
        }
    }
}
