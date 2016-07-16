using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMStringList
	{
		internal DOMStringList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public string this[int index]
		{
			get {
				return null;
			}
		}

		public bool Contains(string @string)
		{
			return false;
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
	}
}
