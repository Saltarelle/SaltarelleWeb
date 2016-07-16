using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPointList
	{
		internal extern SVGPointList();

		[IndexerName("__Item"), FieldProperty]
		public SVGPoint this[int index]
		{
			get;
		}

		public extern SVGPoint AppendItem(SVGPoint newItem);

		public extern void Clear();

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<SVGPoint> GetEnumerator();

		public extern SVGPoint GetItem(int index);

		public extern SVGPoint Initialize(SVGPoint newItem);

		public extern SVGPoint InsertItemBefore(SVGPoint newItem, int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		[FieldProperty]
		public extern int NumberOfItems
		{
			get;
		}

		public extern SVGPoint RemoveItem(int index);

		public extern SVGPoint ReplaceItem(SVGPoint newItem, int index);
	}
}
