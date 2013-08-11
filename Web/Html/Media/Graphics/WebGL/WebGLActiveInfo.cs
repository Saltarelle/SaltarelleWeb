// WebGLActiveInfo.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	/// <summary>
	/// The WebGLActiveInfo interface represents the information returned
	/// from the getActiveAttrib and getActiveUniform calls.
	/// </summary>
	[Imported, Serializable]
	public class WebGLActiveInfo {
		private WebGLActiveInfo() {
		}

		/// <summary>
		/// The name of the requested variable.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The size of the requested variable.
		/// </summary>
		public int Size { get; set; }

		/// <summary>
		/// The data type of the requested variable.
		/// </summary>
		public long Type { get; set; }
	}
}