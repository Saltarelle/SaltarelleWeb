// Uint8Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported]
	public class Uint8Array : TypedArray
	{
		[ScriptName("")]
		public Uint8Array(long length) { }

		[ScriptName("")]
		public Uint8Array(byte[] values) { }

		[ScriptName("")]
		public Uint8Array(TypedArray buffer) { }

		[ScriptName("")]
		public Uint8Array(ArrayBuffer buffer) { }

		[ScriptName("")]
		public Uint8Array(ArrayBuffer buffer, int offset) { }

		[ScriptName("")]
		public Uint8Array(ArrayBuffer buffer, int offset, int length) { }
	}
}
