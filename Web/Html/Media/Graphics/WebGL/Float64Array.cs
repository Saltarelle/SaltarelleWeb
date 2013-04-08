// Float64Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported]
	public class Float64Array : TypedArray
	{
		[ScriptName("")]
		public Float64Array(long length) { }

		[ScriptName("")]
		public Float64Array(double[] values) { }

		[ScriptName("")]
		public Float64Array(TypedArray buffer) { }

		[ScriptName("")]
		public Float64Array(ArrayBuffer buffer) { }

		[ScriptName("")]
		public Float64Array(ArrayBuffer buffer, int offset) { }

		[ScriptName("")]
		public Float64Array(ArrayBuffer buffer, int offset, int length) { }
	}
}
