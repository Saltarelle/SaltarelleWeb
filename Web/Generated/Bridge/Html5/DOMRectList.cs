using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class DOMRectList : IEnumerable<DOMRect>
	{
		internal extern DOMRectList();

		public extern DOMRect this[int index]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<DOMRect> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern DOMRect Item(int index);

		public readonly int Length;
	}
}
