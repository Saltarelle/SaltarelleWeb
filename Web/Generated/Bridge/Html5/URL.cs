using Bridge.Html5.IO;
using Bridge.Html5.Media;
using Bridge.Html5.Media.Source;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class URL
	{
		internal URL()
		{
		}

		public URL(string url)
		{
		}

		public URL(string url, string @base)
		{
		}

		public URL(string url, URL @base)
		{
		}

		public static string CreateObjectURL(Blob blob)
		{
			return null;
		}

		public static string CreateObjectURL(Blob blob, ObjectUrlOptions options)
		{
			return null;
		}

		public static string CreateObjectURL(MediaSource source)
		{
			return null;
		}

		public static string CreateObjectURL(MediaSource source, ObjectUrlOptions options)
		{
			return null;
		}

		public static string CreateObjectURL(MediaStream stream)
		{
			return null;
		}

		public static string CreateObjectURL(MediaStream stream, ObjectUrlOptions options)
		{
			return null;
		}

		[FieldProperty]
		public string Hash
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Host
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Hostname
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Href
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Origin
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Password
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Pathname
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Port
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Protocol
		{
			get {
				return null;
			}
			set {
			}
		}

		public static void RevokeObjectURL(string url)
		{
		}

		[FieldProperty]
		public string Search
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public URLSearchParams SearchParams
		{
			get {
				return default(URLSearchParams);
			}
			set {
			}
		}

		[FieldProperty]
		public string Username
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
