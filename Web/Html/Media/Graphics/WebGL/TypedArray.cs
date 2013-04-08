// TypedArray.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported]
	public abstract class TypedArray : ArrayBufferView
	{
		public void Set(TypedArray array) { }

		public void Set(TypedArray array, long offset) { }

		public void Set<T>(T[] array) { }

		public void Set<T>(T[] array, long offset) { }

		public TypedArray Subarray(long begin)
		{
			return null;
		}

		public TypedArray Subarray(long begin, long end)
		{
			return null;
		}

		[PreserveCase]
		public int BYTES_PER_ELEMENT;

		public long Length;
	}
}
