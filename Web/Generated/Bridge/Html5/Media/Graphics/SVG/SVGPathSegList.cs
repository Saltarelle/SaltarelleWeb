namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGPathSegList
	{
		internal extern SVGPathSegList();

		public extern SVGPathSeg this[int index]
		{
			get;
		}

		public extern SVGPathSeg AppendItem(SVGPathSeg newItem);

		public extern void Clear();

		public extern SVGPathSeg GetItem(int index);

		public extern SVGPathSeg Initialize(SVGPathSeg newItem);

		public extern SVGPathSeg InsertItemBefore(SVGPathSeg newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern SVGPathSeg RemoveItem(int index);

		public extern SVGPathSeg ReplaceItem(SVGPathSeg newItem, int index);
	}
}
