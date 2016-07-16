using Bridge.Html5.Collections.TypedArrays;
using System;

namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Blob
	{
		public extern Blob();

		public extern Blob(TypeOption<ArrayBuffer, ArrayBufferView, Blob, string>[] blobParts);

		public extern Blob(TypeOption<ArrayBuffer, ArrayBufferView, Blob, string>[] blobParts, BlobPropertyBag options);

		public extern void Close();

		[FieldProperty]
		public extern ulong Size
		{
			get;
		}

		public extern Blob Slice();

		public extern Blob Slice(long start);

		public extern Blob Slice(long start, long end);

		public extern Blob Slice(long start, long end, string contentType);

		[FieldProperty]
		public extern string Type
		{
			get;
		}
	}
}
