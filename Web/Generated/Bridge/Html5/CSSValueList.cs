using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CSSValueList : CSSValue
	{
		internal extern CSSValueList();

		[IndexerName("__Item"), FieldProperty]
		public CSSValue this[int index]
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<CSSValue> GetEnumerator();

		public extern CSSValue Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
