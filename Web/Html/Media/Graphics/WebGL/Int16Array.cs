﻿// Int16Array.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported]
	public class Int16Array : TypedArray
	{
		[ScriptName("")]
		public Int16Array(long length) { }

		[ScriptName("")]
		public Int16Array(short[] values) { }

		[ScriptName("")]
		public Int16Array(TypedArray buffer) { }

		[ScriptName("")]
		public Int16Array(ArrayBuffer buffer) { }

		[ScriptName("")]
		public Int16Array(ArrayBuffer buffer, int offset) { }

		[ScriptName("")]
		public Int16Array(ArrayBuffer buffer, int offset, int length) { }
	}
}
