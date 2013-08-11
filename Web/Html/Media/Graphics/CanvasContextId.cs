// CanvasContextId.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics {
	[NamedValues, Imported]
	public enum CanvasContextId {
		[ScriptName("2d")]
		Render2D,
		[ScriptName("webgl")]
		RenderWebGL,
	}
}
