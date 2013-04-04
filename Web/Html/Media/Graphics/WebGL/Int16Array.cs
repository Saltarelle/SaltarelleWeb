// Int16Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;
using CSHARPTYPE = System.Int16;

namespace System.Html.Media.Graphics.WebGL
{
    [IgnoreNamespace, Imported]
    public class Int16Array : ArrayBufferView
    {
        public Int16Array(int length)
        {
        }

        public Int16Array(Int16Array array)
        {
        }

        public Int16Array(CSHARPTYPE[] values)
        {
        }

        public Int16Array(ArrayBuffer buffer)
        {
        }

        public Int16Array(ArrayBuffer buffer, int byteOffset)
        {
        }

        public Int16Array(ArrayBuffer buffer, int byteOffset, int length)
        {
        }

        public static int BytesPerElement
        {
            [InlineCode("Int16Array.BYTES_PER_ELEMENT")]
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

        public void Set(Int16Array array)
        {
        }

        public void Set(Int16Array array, int offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, int offset)
        {
        }

        public Int16Array Subarray(int begin)
        {
            return null;
        }

        public Int16Array Subarray(int begin, int end)
        {
            return null;
        }
    }
}
