namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGTransformList
	{
		internal extern SVGTransformList();

		[IndexerName("__Item"), FieldProperty]
		public SVGTransform this[int index]
		{
			get;
		}

		public extern SVGTransform AppendItem(SVGTransform newItem);

		public extern void Clear();

		public extern SVGTransform Consolidate();

		public extern SVGTransform CreateSVGTransformFromMatrix(SVGMatrix matrix);

		public extern SVGTransform GetItem(int index);

		public extern SVGTransform Initialize(SVGTransform newItem);

		public extern SVGTransform InsertItemBefore(SVGTransform newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern SVGTransform RemoveItem(int index);

		public extern SVGTransform ReplaceItem(SVGTransform newItem, int index);
	}
}
