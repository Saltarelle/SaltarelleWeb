using Bridge.Html5.IO;
using Bridge.Html5.Media;
using Bridge.Html5.Media.Source;

namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class URL
	{
		internal extern URL();

		public extern URL(string url);

		public extern URL(string url, string @base);

		public extern URL(string url, URL @base);

		public static extern string CreateObjectURL(Blob blob);

		public static extern string CreateObjectURL(Blob blob, ObjectUrlOptions options);

		public static extern string CreateObjectURL(MediaSource source);

		public static extern string CreateObjectURL(MediaSource source, ObjectUrlOptions options);

		public static extern string CreateObjectURL(MediaStream stream);

		public static extern string CreateObjectURL(MediaStream stream, ObjectUrlOptions options);

		public string Hash;

		public string Host;

		public string Hostname;

		public string Href;

		public readonly string Origin;

		public string Password;

		public string Pathname;

		public string Port;

		public string Protocol;

		public static extern void RevokeObjectURL(string url);

		public string Search;

		public URLSearchParams SearchParams;

		public string Username;
	}
}
