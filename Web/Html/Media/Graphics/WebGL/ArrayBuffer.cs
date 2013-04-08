﻿// ArrayBuffer.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	/// <summary>
	/// The ArrayBuffer type describes a buffer used to store data for the array buffer views.
	/// </summary>
	[IgnoreNamespace, Imported]
	public class ArrayBuffer
	{
		public ArrayBuffer(long length) { }

		/// <summary>
		/// The length of the ArrayBuffer in bytes, as fixed at construction time.
		/// </summary>
		public long ByteLength;

		/// <summary>
		/// Returns a new ArrayBuffer whose contents are a copy of this
		/// ArrayBuffer's bytes from begin, inclusive, up to end, exclusive.
		/// If either begin or end is negative, it refers to an index from the
		/// end of the array, as opposed to from the beginning.
		/// </summary>
		public ArrayBuffer Slice(long begin, long end = 0)
		{
			return null;
		}
	}
}
