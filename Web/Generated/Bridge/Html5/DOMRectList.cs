using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMRectList
	{
		internal DOMRectList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public DOMRect this[int index]
		{
			get {
				return default(DOMRect);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<DOMRect> GetEnumerator()
		{
			return null;
		}

		public DOMRect Item(int index)
		{
			return default(DOMRect);
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
