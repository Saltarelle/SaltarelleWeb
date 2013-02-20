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
	public interface WebGLShaderPrecisionFormat
	{
		/// <summary>
		/// The base 2 log of the absolute value of the minimum value
		/// that can be represented.
		/// </summary>
		int RangeMin { get; }
		/// <summary>
		/// The base 2 log of the absolute value of the maximum value
		/// that can be represented.
		/// </summary>
		int RangeMax { get; }
		/// <summary>
		/// The number of bits of precision that can be represented.
		/// For integer formats this value is always 0.
		/// </summary>
		int Precision { get; }
	}
}
