using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MimeTypeArray
	{
		internal MimeTypeArray()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public MimeType this[int index]
		{
			get {
				return default(MimeType);
			}
		}

		[IndexerName("__Item"), FieldProperty]
		public MimeType this[string name]
		{
			get {
				return default(MimeType);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<MimeType> GetEnumerator()
		{
			return null;
		}

		public MimeType Item(int index)
		{
			return default(MimeType);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		public MimeType NamedItem(string name)
		{
			return default(MimeType);
		}
	}
}
