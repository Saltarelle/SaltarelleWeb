// Uint8ClampedArray.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported]
	public class Uint8ClampedArray : TypedArray
	{
		[ScriptName("")]
		public Uint8ClampedArray(long length) { }

		[ScriptName("")]
		public Uint8ClampedArray(byte[] values) { }

		[ScriptName("")]
		public Uint8ClampedArray(TypedArray buffer) { }

		[ScriptName("")]
		public Uint8ClampedArray(ArrayBuffer buffer) { }

		[ScriptName("")]
		public Uint8ClampedArray(ArrayBuffer buffer, int offset) { }

		[ScriptName("")]
		public Uint8ClampedArray(ArrayBuffer buffer, int offset, int length) { }
	}
}
