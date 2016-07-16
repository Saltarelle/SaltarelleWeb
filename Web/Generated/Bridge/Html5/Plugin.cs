using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Plugin
	{
		internal Plugin()
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

		[FieldProperty]
		public string Description
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Filename
		{
			get {
				return null;
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

		[FieldProperty]
		public string Name
		{
			get {
				return null;
			}
		}

		public MimeType NamedItem(string name)
		{
			return default(MimeType);
		}

		[FieldProperty]
		public string Version
		{
			get {
				return null;
			}
		}
	}
}
