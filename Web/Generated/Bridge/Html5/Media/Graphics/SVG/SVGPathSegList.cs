using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGPathSegList : IEnumerable<SVGPathSeg>
	{
		internal extern SVGPathSegList();

		public extern SVGPathSeg this[int index]
		{
			get;
		}

		public extern SVGPathSeg AppendItem(SVGPathSeg newItem);

		public extern void Clear();

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<SVGPathSeg> GetEnumerator();

		public extern SVGPathSeg GetItem(int index);

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern SVGPathSeg Initialize(SVGPathSeg newItem);

		public extern SVGPathSeg InsertItemBefore(SVGPathSeg newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern SVGPathSeg RemoveItem(int index);

		public extern SVGPathSeg ReplaceItem(SVGPathSeg newItem, int index);
	}
}
