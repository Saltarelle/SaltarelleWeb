// OverSampleType.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[Imported, NamedValues]
	public enum OverSampleType {
		None,
		[ScriptName("2x")]
		_2x,
		[ScriptName("4x")]
		_4x,
	}
}
