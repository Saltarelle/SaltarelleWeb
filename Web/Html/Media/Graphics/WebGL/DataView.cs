// DataView.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL
{
	[IgnoreNamespace, Imported]
	public class DataView
	{
		[ScriptName("")]
		public DataView(ArrayBuffer array) { }

		[ScriptName("")]
		public DataView(ArrayBuffer array, long offset) { }

		[ScriptName("")]
		public DataView(ArrayBuffer array, long offset, long length) { }

		public void SetInt8(long byteOffset, sbyte value) { }

		public void SetUint8(long byteOffset, byte value) { }

		public void SetInt16(long byteOffset, short value) { }

		public void SetInt16(long byteOffset, short value, bool littleEndian) { }

		public void SetUint16(long byteOffset, ushort value) { }

		public void SetUint16(long byteOffset, ushort value, bool littleEndian) { }

		public void SetInt32(long byteOffset, int value) { }

		public void SetInt32(long byteOffset, int value, bool littleEndian) { }

		public void SetUint32(long byteOffset, uint value) { }

		public void SetUint32(long byteOffset, uint value, bool littleEndian) { }

		public void SetFloat32(long byteOffset, float value) { }

		public void SetFloat32(long byteOffset, float value, bool littleEndian) { }

		public void SetFloat64(long byteOffset, double value) { }

		public void SetFloat64(long byteOffset, double value, bool littleEndian) { }

		public sbyte GetInt8(long byteOffset)
		{
			return 0;
		}

		public byte GetUint8(long byteOffset)
		{
			return 0;
		}

		public short GetInt16(long byteOffset)
		{
			return 0;
		}

		public short GetInt16(long byteOffset, bool littleEndian)
		{
			return 0;
		}

		public ushort GetUint16(long byteOffset)
		{
			return 0;
		}

		public ushort GetUint16(long byteOffset, bool littleEndian)
		{
			return 0;
		}

		public int GetInt32(long byteOffset)
		{
			return 0;
		}

		public int GetInt32(long byteOffset, bool littleEndian)
		{
			return 0;
		}

		public uint GetUint32(long byteOffset)
		{
			return 0;
		}

		public uint GetUint32(long byteOffset, bool littleEndian)
		{
			return 0;
		}

		public float GetFloat32(long byteOffset)
		{
			return 0;
		}

		public float GetFloat32(long byteOffset, bool littleEndian)
		{
			return 0;
		}

		public double GetFloat64(long byteOffset)
		{
			return 0;
		}

		public double GetFloat64(long byteOffset, bool littleEndian)
		{
			return 0;
		}
	}
}
