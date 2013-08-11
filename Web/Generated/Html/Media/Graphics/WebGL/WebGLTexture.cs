// WebGLTexture.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	/// <summary>
	/// The WebGLTexture interface represents an OpenGL Texture Object.
	/// The underlying object is created as if by calling glGenTextures,
	/// bound as if by calling glBindTexture and destroyed as if
	/// by calling glDeleteTextures.
	/// </summary>
	[IgnoreNamespace, Imported]
	public class WebGLTexture : WebGLObject {
		private WebGLTexture() {
		}
	}
}