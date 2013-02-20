// WebGLProgram.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	/// <summary>
	/// The WebGLProgram interface represents an OpenGL Program Object.
	/// The underlying object is created as if by calling glCreateProgram,
	/// used as if by calling glUseProgram and destroyed as if
	/// by calling glDeleteProgram.
	/// </summary>
	[IgnoreNamespace, Imported]
	public interface WebGLProgram : WebGLObject
	{
	}
}
