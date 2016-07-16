using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Plugin
	{
		internal extern Plugin();

		[IndexerName("__Item"), FieldProperty]
		public MimeType this[int index]
		{
			get;
		}

		[IndexerName("__Item"), FieldProperty]
		public MimeType this[string name]
		{
			get;
		}

		[FieldProperty]
		public extern string Description
		{
			get;
		}

		[FieldProperty]
		public extern string Filename
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<MimeType> GetEnumerator();

		public extern MimeType Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
		}

		public extern MimeType NamedItem(string name);

		[FieldProperty]
		public extern string Version
		{
			get;
		}
	}
}
