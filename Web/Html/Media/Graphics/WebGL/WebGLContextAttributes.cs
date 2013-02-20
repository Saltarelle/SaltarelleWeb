// WebGLContextAttributes.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace]
	public static class WebGLContextAttributes
	{
		[InlineCode(
			"{{alpha: {alpha}, depth: {depth}, stencil: {stencil}, antialias: {antialias}, premultipliedAlpha: {premultipliedAlpha}, preserveDrawingBuffer: {preserveDrawingBuffer}}}"
			)]
		public static Dictionary<string, bool> Get(bool alpha, bool depth, bool stencil,
		                                           bool antialias, bool premultipliedAlpha, bool preserveDrawingBuffer)
		{
			var result = new Dictionary<string, bool>();
			result.Add("alpha", alpha);
			result.Add("depth", depth);
			result.Add("stencil", stencil);
			result.Add("antialias", antialias);
			result.Add("premultipliedAlpha", premultipliedAlpha);
			result.Add("preserveDrawingBuffer", preserveDrawingBuffer);
			return result;
		}
	}
}
