using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TouchList
	{
		internal TouchList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public Touch this[int index]
		{
			get {
				return default(Touch);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<Touch> GetEnumerator()
		{
			return null;
		}

		public Touch IdentifiedTouch(int identifier)
		{
			return default(Touch);
		}

		public Touch Item(int index)
		{
			return default(Touch);
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
