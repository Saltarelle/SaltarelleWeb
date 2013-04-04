// Uint16Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;
using CSHARPTYPE = System.UInt16;

namespace System.Html.Media.Graphics.WebGL
{
    [IgnoreNamespace, Imported]
    public class Uint16Array : ArrayBufferView
    {
        [ScriptName("")]
        public Uint16Array(int length)
        {
        }

        [ScriptName("")]
        public Uint16Array(Uint16Array array)
        {
        }

        [ScriptName("")]
        public Uint16Array(CSHARPTYPE[] values)
        {
        }

        [ScriptName("")]
        public Uint16Array(ArrayBuffer buffer)
        {
        }

        [ScriptName("")]
        public Uint16Array(ArrayBuffer buffer, int byteOffset)
        {
        }

        [ScriptName("")]
        public Uint16Array(ArrayBuffer buffer, int byteOffset, int length)
        {
        }

        public static int BytesPerElement
        {
            [InlineCode("Uint16Array.BYTES_PER_ELEMENT")]
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

        public void Set(Uint16Array array)
        {
        }

        public void Set(Uint16Array array, int offset)
        {
        }

        public void Set(CSHARPTYPE[] array)
        {
        }

        public void Set(CSHARPTYPE[] array, int offset)
        {
        }

        public Uint16Array Subarray(int begin)
        {
            return null;
        }

        public Uint16Array Subarray(int begin, int end)
        {
            return null;
        }
    }
}
