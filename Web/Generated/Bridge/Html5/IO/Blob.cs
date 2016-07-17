using Bridge.Html5.Collections.TypedArrays;
using System;

namespace Bridge.Html5.IO
{
	[Namespace(false), External]
	public partial class Blob
	{
		public extern Blob();

		public extern Blob(TypeOption<ArrayBuffer, ArrayBufferView, Blob, string>[] blobParts);

		public extern Blob(TypeOption<ArrayBuffer, ArrayBufferView, Blob, string>[] blobParts, BlobPropertyBag options);

		public extern void Close();

		public readonly ulong Size;

		public extern Blob Slice();

		public extern Blob Slice(long start);

		public extern Blob Slice(long start, long end);

		public extern Blob Slice(long start, long end, string contentType);

		public readonly string Type;
	}
}
