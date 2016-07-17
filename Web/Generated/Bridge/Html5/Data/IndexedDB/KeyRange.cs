namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBKeyRange")]
	public partial class KeyRange
	{
		internal extern KeyRange();

		public static extern KeyRange Bound(object lower, object upper);

		public static extern KeyRange Bound(object lower, object upper, bool lowerOpen);

		public static extern KeyRange Bound(object lower, object upper, bool lowerOpen, bool upperOpen);

		public readonly object Lower;

		public static extern KeyRange LowerBound(object lower);

		public static extern KeyRange LowerBound(object lower, bool open);

		public readonly bool LowerOpen;

		[Name("only")]
		public static extern KeyRange OnLy(object value);

		public readonly object Upper;

		public static extern KeyRange UpperBound(object upper);

		public static extern KeyRange UpperBound(object upper, bool open);

		public readonly bool UpperOpen;
	}
}
