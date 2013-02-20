// WebGLContextAttributes.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported, Serializable]
	public class WebGLContextAttributes
	{
		public WebGLContextAttributes(bool alpha, bool depth, bool stencil,
		                              bool antialias, bool premultipliedAlpha, bool preserveDrawingBuffer)
		{
		}

		[ScriptName("alpha")] public bool Alpha;

		[ScriptName("depth")] public bool Depth;

		[ScriptName("stencil")] public bool Stencil;

		[ScriptName("antialias")] public bool AntiAlias;

		[ScriptName("premultipliedAlpha")] public bool PremultipliedAlpha;

		[ScriptName("preserveDrawingBuffer")] public bool PreserveDrawingBuffer;
	}
}
