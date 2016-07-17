using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class TouchList : IEnumerable<Touch>
	{
		internal extern TouchList();

		public extern Touch this[int index]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<Touch> GetEnumerator();

		public extern Touch IdentifiedTouch(int identifier);

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern Touch Item(int index);

		public readonly int Length;
	}
}
