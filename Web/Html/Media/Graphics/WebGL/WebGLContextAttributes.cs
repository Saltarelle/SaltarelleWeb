// WebGLContextAttributes.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	/// <summary>
	/// The WebGLContextAttributes dictionary contains drawing surface
	/// attributes and is passed as the second parameter to getContext. 
	/// </summary>
	[IgnoreNamespace, Imported, Serializable]
	public class WebGLContextAttributes {
		public WebGLContextAttributes(bool alpha, bool depth, bool stencil, bool antialias, bool premultipliedAlpha, bool preserveDrawingBuffer) {
		}

		/// <summary>
		/// If the value is true, the drawing buffer has an alpha channel
		/// for the purposes of performing OpenGL destination alpha
		/// operations and compositing with the page.
		/// If the value is false, no alpha buffer is available.
		/// </summary>
		public bool Alpha;

		/// <summary>
		/// If the value is true and the implementation supports antialiasing
		/// the drawing buffer will perform antialiasing using its choice of
		/// technique (multisample/supersample) and quality. If the value is false
		/// or the implementation does not support antialiasing,
		/// no antialiasing is performed.
		/// </summary>
		public bool Antialias;

		/// <summary>
		/// If the value is true, the drawing buffer has a depth buffer of
		/// at least 16 bits. If the value is false, no depth buffer is available.
		/// </summary>
		public bool Depth;

		/// <summary>
		/// If the value is true the page compositor will assume the drawing buffer
		/// contains colors with premultiplied alpha. If the value is false the page
		/// compositor will assume that colors in the drawing buffer are not premultiplied.
		/// This flag is ignored if the alpha flag is false.
		/// </summary>
		public bool PremultipliedAlpha;

		/// <summary>
		/// If false, once the drawing buffer is presented, the contents of the
		/// drawing buffer are cleared to their default values. All elements of the
		/// drawing buffer (color, depth and stencil) are cleared. If the value is
		/// true the buffers will not be cleared and will preserve their values until
		/// cleared or overwritten by the author.
		/// </summary>
		public bool PreserveDrawingBuffer;

		/// <summary>
		/// If the value is true, the drawing buffer has a stencil buffer
		/// of at least 8 bits. If the value is false, no stencil buffer is available.
		/// </summary>
		public bool Stencil;
	}
}