// Float64Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;
using CSHARPTYPE = System.Double;

namespace System.Html.Media.Graphics.WebGL
{
    [IgnoreNamespace, Imported]
    public class Float64Array : ArrayBufferView
    {
        public Float64Array(uint length)
        {
        }

        public Float64Array(Float64Array array)
        {
        }

        public Float64Array(CSHARPTYPE[] values)
        {
        }

        public Float64Array(ArrayBuffer buffer)
        {
        }

        public Float64Array(ArrayBuffer buffer, uint byteOffset)
        {
        }

        public Float64Array(ArrayBuffer buffer, uint byteOffset, uint length)
        {
        }

        public static uint BytesPerElement
        {
            [InlineCode("Float64Array.BYTES_PER_ELEMENT")]
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

        public void Set(Float64Array array)
        {
        }

        public void Set(Float64Array array, uint offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, uint offset)
        {
        }

        public Float64Array Subarray(int begin)
        {
            return null;
        }

        public Float64Array Subarray(int begin, int end)
        {
            return null;
        }
    }
}
