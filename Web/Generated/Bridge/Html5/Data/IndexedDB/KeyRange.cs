namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBKeyRange")]
	public partial class KeyRange
	{
		internal extern KeyRange();

		public static extern KeyRange Bound(object lower, object upper);

		public static extern KeyRange Bound(object lower, object upper, bool lowerOpen);

		public static extern KeyRange Bound(object lower, object upper, bool lowerOpen, bool upperOpen);

		[FieldProperty]
		public extern object Lower
		{
			get;
		}

		public static extern KeyRange LowerBound(object lower);

		public static extern KeyRange LowerBound(object lower, bool open);

		[FieldProperty]
		public extern bool LowerOpen
		{
			get;
		}

		[Name("only")]
		public static extern KeyRange OnLy(object value);

		[FieldProperty]
		public extern object Upper
		{
			get;
		}

		public static extern KeyRange UpperBound(object upper);

		public static extern KeyRange UpperBound(object upper, bool open);

		[FieldProperty]
		public extern bool UpperOpen
		{
			get;
		}
	}
}
