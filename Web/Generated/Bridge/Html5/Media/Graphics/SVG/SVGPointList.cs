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

		public extern SVGPoint GetItem(int index);

		public extern SVGPoint Initialize(SVGPoint newItem);

		public extern SVGPoint InsertItemBefore(SVGPoint newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern SVGPoint RemoveItem(int index);

		public extern SVGPoint ReplaceItem(SVGPoint newItem, int index);
	}
}
