using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGLengthList : IEnumerable<SVGLength>
	{
		internal extern SVGLengthList();

		public extern SVGLength this[int index]
		{
			get;
		}

		public extern SVGLength AppendItem(SVGLength newItem);

		public extern void Clear();

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<SVGLength> GetEnumerator();

		public extern SVGLength GetItem(int index);

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern SVGLength Initialize(SVGLength newItem);

		public extern SVGLength InsertItemBefore(SVGLength newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern SVGLength RemoveItem(int index);

		public extern SVGLength ReplaceItem(SVGLength newItem, int index);
	}
}
