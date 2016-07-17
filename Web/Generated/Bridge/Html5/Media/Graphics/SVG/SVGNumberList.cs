using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGNumberList : IEnumerable<SVGNumber>
	{
		internal extern SVGNumberList();

		public extern SVGNumber this[int index]
		{
			get;
		}

		public extern SVGNumber AppendItem(SVGNumber newItem);

		public extern void Clear();

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<SVGNumber> GetEnumerator();

		public extern SVGNumber GetItem(int index);

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern SVGNumber Initialize(SVGNumber newItem);

		public extern SVGNumber InsertItemBefore(SVGNumber newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern SVGNumber RemoveItem(int index);

		public extern SVGNumber ReplaceItem(SVGNumber newItem, int index);
	}
}
