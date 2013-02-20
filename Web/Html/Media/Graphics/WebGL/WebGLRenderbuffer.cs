// WebGLRenderbuffer.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	/// <summary>
	/// The WebGLRenderbuffer interface represents an OpenGL Renderbuffer Object.
	/// The underlying object is created as if by calling glGenRenderbuffers,
	/// bound as if by calling glBindRenderbuffer and destroyed as if by
	/// calling glDeleteRenderbuffers.
	/// </summary>
	[IgnoreNamespace, Imported]
	public class WebGLRenderbuffer : WebGLObject
	{
		private WebGLRenderbuffer()
		{
		}
	}
}
