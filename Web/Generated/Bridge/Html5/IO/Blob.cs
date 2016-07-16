using Bridge.Html5.Collections.TypedArrays;
using System;

namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Blob
	{
		public Blob()
		{
		}

		public Blob(TypeOption<ArrayBuffer, ArrayBufferView, Blob, string>[] blobParts)
		{
		}

		public Blob(TypeOption<ArrayBuffer, ArrayBufferView, Blob, string>[] blobParts, BlobPropertyBag options)
		{
		}

		public void Close()
		{
		}

		[FieldProperty]
		public ulong Size
		{
			get {
				return 0;
			}
		}

		public Blob Slice()
		{
			return default(Blob);
		}

		public Blob Slice(long start)
		{
			return default(Blob);
		}

		public Blob Slice(long start, long end)
		{
			return default(Blob);
		}

		public Blob Slice(long start, long end, string contentType)
		{
			return default(Blob);
		}

		[FieldProperty]
		public string Type
		{
			get {
				return null;
			}
		}
	}
}
