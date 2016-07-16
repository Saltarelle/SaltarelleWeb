using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMRectList
	{
		internal extern DOMRectList();

		[IndexerName("__Item"), FieldProperty]
		public DOMRect this[int index]
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<DOMRect> GetEnumerator();

		public extern DOMRect Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
