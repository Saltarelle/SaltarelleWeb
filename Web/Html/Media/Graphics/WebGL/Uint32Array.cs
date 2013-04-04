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
        public Uint32Array(uint length)
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

        public Uint32Array(ArrayBuffer buffer, uint byteOffset)
        {
        }

        public Uint32Array(ArrayBuffer buffer, uint byteOffset, uint length)
        {
        }

        public static uint BytesPerElement
        {
            [InlineCode("Uint32Array.BYTES_PER_ELEMENT")]
            get;
            private set;
        }

        public uint Length { get; private set; }

        [IntrinsicProperty]
        public CSHARPTYPE this[uint index] { get; set; }

        public void Set(Uint32Array array)
        {
        }

        public void Set(Uint32Array array, uint offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, uint offset)
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
