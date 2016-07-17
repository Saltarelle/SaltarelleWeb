using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.IO
{
	[Namespace("false"), External]
	public partial class FileReaderSync
	{
		public extern FileReaderSync();

		public extern ArrayBuffer ReadAsArrayBuffer(Blob blob);

		public extern string ReadAsBinaryString(Blob blob);

		public extern string ReadAsDataURL(Blob blob);

		public extern string ReadAsText(Blob blob);

		public extern string ReadAsText(Blob blob, string encoding);
	}
}
