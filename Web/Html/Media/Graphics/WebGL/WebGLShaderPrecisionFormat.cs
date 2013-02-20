// WebGLShaderPrecisionFormat.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	/// <summary>
	/// The WebGLShaderPrecisionFormat interface represents the information
	/// returned from the getShaderPrecisionFormat call. 
	/// </summary>
	[IgnoreNamespace, Imported]
	public class WebGLShaderPrecisionFormat
	{
		private WebGLShaderPrecisionFormat()
		{
		}

		/// <summary>
		/// The base 2 log of the absolute value of the minimum value
		/// that can be represented.
		/// </summary>
		public int RangeMin;

		/// <summary>
		/// The base 2 log of the absolute value of the maximum value
		/// that can be represented.
		/// </summary>
		public int RangeMax;

		/// <summary>
		/// The number of bits of precision that can be represented.
		/// For integer formats this value is always 0.
		/// </summary>
		public int Precision;
	}
}
