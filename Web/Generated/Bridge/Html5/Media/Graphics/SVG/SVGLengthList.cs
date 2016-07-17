namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGLengthList
	{
		internal extern SVGLengthList();

		[IndexerName("__Item"), FieldProperty]
		public SVGLength this[int index]
		{
			get;
		}

		public extern SVGLength AppendItem(SVGLength newItem);

		public extern void Clear();

		public extern SVGLength GetItem(int index);

		public extern SVGLength Initialize(SVGLength newItem);

		public extern SVGLength InsertItemBefore(SVGLength newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern SVGLength RemoveItem(int index);

		public extern SVGLength ReplaceItem(SVGLength newItem, int index);
	}
}
