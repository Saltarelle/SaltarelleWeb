// WebGLShaderPrecisionFormat.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	/// <summary>
	/// The WebGLShaderPrecisionFormat interface represents the information
	/// returned from the getShaderPrecisionFormat call. 
	/// </summary>
	[Imported, Serializable]
	public class WebGLShaderPrecisionFormat {
		private WebGLShaderPrecisionFormat() {
		}

		/// <summary>
		/// The number of bits of precision that can be represented.
		/// For integer formats this value is always 0.
		/// </summary>
		public int Precision { get; set; }

		/// <summary>
		/// The base 2 log of the absolute value of the maximum value
		/// that can be represented.
		/// </summary>
		public int RangeMax { get; set; }

		/// <summary>
		/// The base 2 log of the absolute value of the minimum value
		/// that can be represented.
		/// </summary>
		public int RangeMin { get; set; }
	}
}