// ArrayBuffer.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported]
	public class ArrayBuffer
	{
		[ScriptName("byteLength")]
		public uint ByteLength;

		[ScriptName("slice")]
		private ArrayBuffer Slice(long begin, long end = 0)
		{
			return new ArrayBuffer();
		}
	}
}
