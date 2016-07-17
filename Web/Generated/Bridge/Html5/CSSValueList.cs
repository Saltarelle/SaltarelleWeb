using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class CSSValueList : CSSValue, IEnumerable<CSSValue>
	{
		internal extern CSSValueList();

		public extern CSSValue this[int index]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<CSSValue> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern CSSValue Item(int index);

		public readonly int Length;
	}
}
