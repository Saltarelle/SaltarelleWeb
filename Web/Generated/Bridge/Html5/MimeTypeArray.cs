using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MimeTypeArray
	{
		internal extern MimeTypeArray();

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

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<MimeType> GetEnumerator();

		public extern MimeType Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		public extern MimeType NamedItem(string name);
	}
}
