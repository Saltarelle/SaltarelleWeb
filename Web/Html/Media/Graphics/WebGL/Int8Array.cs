// Int8Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;
using CSHARPTYPE = System.SByte;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported]
	public class Int8Array : ArrayBufferView
	{
        public Int8Array(uint length)
        {
        }

        public Int8Array(Int8Array array)
        {
        }

        public Int8Array(CSHARPTYPE[] values)
		{
		}

        public Int8Array(ArrayBuffer buffer)
        {
        }

        public Int8Array(ArrayBuffer buffer, uint byteOffset)
        {
        }

        public Int8Array(ArrayBuffer buffer, uint byteOffset, uint length)
        {
        }

        public static uint BytesPerElement 
        { 
            [InlineCode("Int8Array.BYTES_PER_ELEMENT")]
            get; 
            private set; 
        }

        public uint Length { get; private set; }

        [IntrinsicProperty]
        public CSHARPTYPE this[uint index] { get; set; }

        public void Set(Int8Array array)
        {
        }

        public void Set(Int8Array array, uint offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, uint offset)
        {
        }

        public Int8Array Subarray(int begin)
        {
            return null;
        }

        public Int8Array Subarray(int begin, int end)
        {
            return null;
        }
	}
}
