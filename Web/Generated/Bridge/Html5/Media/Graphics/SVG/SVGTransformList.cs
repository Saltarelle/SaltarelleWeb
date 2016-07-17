using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGTransformList : IEnumerable<SVGTransform>
	{
		internal extern SVGTransformList();

		public extern SVGTransform this[int index]
		{
			get;
		}

		public extern SVGTransform AppendItem(SVGTransform newItem);

		public extern void Clear();

		public extern SVGTransform Consolidate();

		public extern SVGTransform CreateSVGTransformFromMatrix(SVGMatrix matrix);

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<SVGTransform> GetEnumerator();

		public extern SVGTransform GetItem(int index);

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern SVGTransform Initialize(SVGTransform newItem);

		public extern SVGTransform InsertItemBefore(SVGTransform newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern SVGTransform RemoveItem(int index);

		public extern SVGTransform ReplaceItem(SVGTransform newItem, int index);
	}
}
