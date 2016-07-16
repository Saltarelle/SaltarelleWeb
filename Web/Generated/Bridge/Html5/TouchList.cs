using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TouchList
	{
		internal extern TouchList();

		[IndexerName("__Item"), FieldProperty]
		public Touch this[int index]
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<Touch> GetEnumerator();

		public extern Touch IdentifiedTouch(int identifier);

		public extern Touch Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
