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
        [ScriptName("")]
        public Int32Array(long length)
        {
        }

        [ScriptName("")]
        public Int32Array(Int32Array array)
        {
        }

        [ScriptName("")]
        public Int32Array(CSHARPTYPE[] values)
        {
        }

        [ScriptName("")]
        public Int32Array(ArrayBuffer buffer)
        {
        }

        [ScriptName("")]
        public Int32Array(ArrayBuffer buffer, long byteOffset)
        {
        }

        [ScriptName("")]
        public Int32Array(ArrayBuffer buffer, long byteOffset, long length)
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

        public void Set(Int32Array array)
        {
        }

        public void Set(Int32Array array, long offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, long offset)
        {
        }

        public Int32Array Subarray(long begin)
        {
            return null;
        }

        public Int32Array Subarray(long begin, long end)
        {
            return null;
        }
    }
}
