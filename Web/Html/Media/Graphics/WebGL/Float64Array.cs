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
        public Float64Array(long length)
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
        public Float64Array(ArrayBuffer buffer, long byteOffset)
        {
        }

        [ScriptName("")]
        public Float64Array(ArrayBuffer buffer, long byteOffset, long length)
        {
        }

        [IntrinsicProperty, ScriptName("BYTES_PER_ELEMENT")]
        public static int BytesPerElementStatic { get { return 0; } }

        [IntrinsicProperty, ScriptName("BYTES_PER_ELEMENT")]
        public int BytesPerElement { get { return 0; } }

        public long Length { get; private set; }

        [IntrinsicProperty]
        public CSHARPTYPE this[int index]
        {
            get { return default(CSHARPTYPE); }
            set { }
        }

        public void Set(Float64Array array)
        {
        }

        public void Set(Float64Array array, long offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, long offset)
        {
        }

        public Float64Array Subarray(long begin)
        {
            return null;
        }

        public Float64Array Subarray(long begin, long end)
        {
            return null;
        }
    }
}
