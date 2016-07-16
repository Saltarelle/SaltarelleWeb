using Bridge.Html5.IO;
using Bridge.Html5.Media;
using Bridge.Html5.Media.Source;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern string Hash
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Host
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Hostname
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Href
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Origin
		{
			get;
		}

		[FieldProperty]
		public extern string Password
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Pathname
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Port
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Protocol
		{
			get;
			set;
		}

		public static extern void RevokeObjectURL(string url);

		[FieldProperty]
		public extern string Search
		{
			get;
			set;
		}

		[FieldProperty]
		public extern URLSearchParams SearchParams
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Username
		{
			get;
			set;
		}
	}
}
