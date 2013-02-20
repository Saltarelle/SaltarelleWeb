// WebGLFramebuffer.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	/// <summary>
	/// The WebGLFramebuffer interface represents an OpenGL Framebuffer Object.
	/// The underlying object is created as if by calling glGenFramebuffers,
	/// bound as if by calling glBindFramebuffer and destroyed as if
	/// by calling glDeleteFramebuffers.
	/// </summary>
	[IgnoreNamespace, Imported]
	public interface WebGLFramebuffer : WebGLObject
	{
	}
}
