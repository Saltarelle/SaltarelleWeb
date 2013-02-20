// WebGLShader.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	/// <summary>
	/// The WebGLShader interface represents an OpenGL Shader Object.
	/// The underlying object is created as if by calling glCreateShader,
	/// attached to a Program as if by calling glAttachShader and
	/// destroyed as if by calling glDeleteShader.
	/// </summary>
	[IgnoreNamespace, Imported]
	public class WebGLShader : WebGLObject
	{
		private WebGLShader()
		{
		}
	}
}
