namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBKeyRange")]
	public partial class KeyRange
	{
		internal KeyRange()
		{
		}

		public static KeyRange Bound(object lower, object upper)
		{
			return default(KeyRange);
		}

		public static KeyRange Bound(object lower, object upper, bool lowerOpen)
		{
			return default(KeyRange);
		}

		public static KeyRange Bound(object lower, object upper, bool lowerOpen, bool upperOpen)
		{
			return default(KeyRange);
		}

		[FieldProperty]
		public object Lower
		{
			get {
				return null;
			}
		}

		public static KeyRange LowerBound(object lower)
		{
			return default(KeyRange);
		}

		public static KeyRange LowerBound(object lower, bool open)
		{
			return default(KeyRange);
		}

		[FieldProperty]
		public bool LowerOpen
		{
			get {
				return false;
			}
		}

		[Name("only")]
		public static KeyRange OnLy(object value)
		{
			return default(KeyRange);
		}

		[FieldProperty]
		public object Upper
		{
			get {
				return null;
			}
		}

		public static KeyRange UpperBound(object upper)
		{
			return default(KeyRange);
		}

		public static KeyRange UpperBound(object upper, bool open)
		{
			return default(KeyRange);
		}

		[FieldProperty]
		public bool UpperOpen
		{
			get {
				return false;
			}
		}
	}
}
