using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaList
	{
		internal MediaList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public string this[int index]
		{
			get {
				return null;
			}
		}

		public void AppendMedium(string newMedium)
		{
		}

		public void DeleteMedium(string oldMedium)
		{
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		public string Item(int index)
		{
			return null;
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string MediaText
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
