﻿// WebGLActiveInfo.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	/// <summary>
	/// The WebGLActiveInfo interface represents the information returned
	/// from the getActiveAttrib and getActiveUniform calls.
	/// </summary>
	[IgnoreNamespace, Imported]
	public class WebGLActiveInfo
	{
		private WebGLActiveInfo()
		{
		}

		/// <summary>
		/// The size of the requested variable.
		/// </summary>
		public int Size;

		/// <summary>
		/// The data type of the requested variable.
		/// </summary>
		public long Type;

		/// <summary>
		/// The name of the requested variable.
		/// </summary>
		public string Name;
	}
}
