using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGPointList : IEnumerable<SVGPoint>
	{
		internal extern SVGPointList();

		public extern SVGPoint this[int index]
		{
			get;
		}

		public extern SVGPoint AppendItem(SVGPoint newItem);

		public extern void Clear();

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<SVGPoint> GetEnumerator();

		public extern SVGPoint GetItem(int index);

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern SVGPoint Initialize(SVGPoint newItem);

		public extern SVGPoint InsertItemBefore(SVGPoint newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern SVGPoint RemoveItem(int index);

		public extern SVGPoint ReplaceItem(SVGPoint newItem, int index);
	}
}
