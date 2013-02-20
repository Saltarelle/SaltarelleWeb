// WebGLBuffer.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	/// <summary>
	/// The WebGLBuffer interface represents an OpenGL Buffer Object.
	/// The underlying object is created as if by calling glGenBuffers,
	/// bound as if by calling glBindBuffer and destroyed as if
	/// by calling glDeleteBuffers.
	/// </summary>
	[IgnoreNamespace, Imported]
	public class WebGLBuffer : WebGLObject
	{
		private WebGLBuffer()
		{
		}
	}
}
