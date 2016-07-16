using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CSSValueList : CSSValue
	{
		internal CSSValueList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public CSSValue this[int index]
		{
			get {
				return default(CSSValue);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<CSSValue> GetEnumerator()
		{
			return null;
		}

		public CSSValue Item(int index)
		{
			return default(CSSValue);
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
