using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPointList
	{
		internal SVGPointList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public SVGPoint this[int index]
		{
			get {
				return default(SVGPoint);
			}
		}

		public SVGPoint AppendItem(SVGPoint newItem)
		{
			return default(SVGPoint);
		}

		public void Clear()
		{
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGPoint> GetEnumerator()
		{
			return null;
		}

		public SVGPoint GetItem(int index)
		{
			return default(SVGPoint);
		}

		public SVGPoint Initialize(SVGPoint newItem)
		{
			return default(SVGPoint);
		}

		public SVGPoint InsertItemBefore(SVGPoint newItem, int index)
		{
			return default(SVGPoint);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int NumberOfItems
		{
			get {
				return 0;
			}
		}

		public SVGPoint RemoveItem(int index)
		{
			return default(SVGPoint);
		}

		public SVGPoint ReplaceItem(SVGPoint newItem, int index)
		{
			return default(SVGPoint);
		}
	}
}
