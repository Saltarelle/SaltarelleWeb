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
        [ScriptName("")]
        public Float64Array(int length)
        {
        }

        [ScriptName("")]
        public Float64Array(Float64Array array)
        {
        }

        [ScriptName("")]
        public Float64Array(CSHARPTYPE[] values)
        {
        }

        [ScriptName("")]
        public Float64Array(ArrayBuffer buffer)
        {
        }

        [ScriptName("")]
        public Float64Array(ArrayBuffer buffer, int byteOffset)
        {
        }

        [ScriptName("")]
        public Float64Array(ArrayBuffer buffer, int byteOffset, int length)
        {
        }

        public static int BytesPerElement
        {
            [InlineCode("Float64Array.BYTES_PER_ELEMENT")]
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

        public void Set(Float64Array array)
        {
        }

        public void Set(Float64Array array, int offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, int offset)
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
