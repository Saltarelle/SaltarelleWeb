using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class FileReaderSync
	{
		public FileReaderSync()
		{
		}

		public ArrayBuffer ReadAsArrayBuffer(Blob blob)
		{
			return default(ArrayBuffer);
		}

		public string ReadAsBinaryString(Blob blob)
		{
			return null;
		}

		public string ReadAsDataURL(Blob blob)
		{
			return null;
		}

		public string ReadAsText(Blob blob)
		{
			return null;
		}

		public string ReadAsText(Blob blob, string encoding)
		{
			return null;
		}
	}
}
