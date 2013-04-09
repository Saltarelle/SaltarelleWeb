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
        [ScriptName("")]
        public Float32Array(long length)
        {
        }

        [ScriptName("")]
        public Float32Array(Float32Array array)
        {
        }

        [ScriptName("")]
        public Float32Array(CSHARPTYPE[] values)
        {
        }

        [ScriptName("")]
        public Float32Array(ArrayBuffer buffer)
        {
        }

        [ScriptName("")]
        public Float32Array(ArrayBuffer buffer, long byteOffset)
        {
        }

        [ScriptName("")]
        public Float32Array(ArrayBuffer buffer, long byteOffset, long length)
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

        public void Set(Float32Array array)
        {
        }

        public void Set(Float32Array array, long offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, long offset)
        {
        }

        public Float32Array Subarray(long begin)
        {
            return null;
        }

        public Float32Array Subarray(long begin, long end)
        {
            return null;
        }
    }
}
