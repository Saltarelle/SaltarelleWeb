// ArrayBufferView.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	/// <summary>
	/// The ArrayBufferView type holds information shared among
	/// all of the types of views of ArrayBuffers.
	/// </summary>
	[IgnoreNamespace, Imported]
	public class ArrayBufferView
	{
		/// <summary>
		/// The ArrayBuffer that this ArrayBufferView references.
		/// </summary>
		public ArrayBuffer Buffer;
		/// <summary>
		/// The offset of this ArrayBufferView from the start of
		/// its ArrayBuffer, in bytes, as fixed at construction time.
		/// </summary>
		public uint ByteOffset;
		/// <summary>
		/// The length of the ArrayBufferView in bytes, as fixed at construction time.
		/// </summary>
		public uint ByteLength;
	}
}
