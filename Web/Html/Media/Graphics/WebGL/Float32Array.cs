// Float32Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported]
	public class Float32Array : TypedArray
	{
		[ScriptName("")]
		public Float32Array(long length) { }

		[ScriptName("")]
		public Float32Array(float[] values) { }

		[ScriptName("")]
		public Float32Array(TypedArray buffer) { }

		[ScriptName("")]
		public Float32Array(ArrayBuffer buffer) { }

		[ScriptName("")]
		public Float32Array(ArrayBuffer buffer, int offset) { }

		[ScriptName("")]
		public Float32Array(ArrayBuffer buffer, int offset, int length) { }
	}
}
