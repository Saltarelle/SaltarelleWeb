using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPathSegList
	{
		internal SVGPathSegList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public SVGPathSeg this[int index]
		{
			get {
				return default(SVGPathSeg);
			}
		}

		public SVGPathSeg AppendItem(SVGPathSeg newItem)
		{
			return default(SVGPathSeg);
		}

		public void Clear()
		{
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGPathSeg> GetEnumerator()
		{
			return null;
		}

		public SVGPathSeg GetItem(int index)
		{
			return default(SVGPathSeg);
		}

		public SVGPathSeg Initialize(SVGPathSeg newItem)
		{
			return default(SVGPathSeg);
		}

		public SVGPathSeg InsertItemBefore(SVGPathSeg newItem, int index)
		{
			return default(SVGPathSeg);
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

		public SVGPathSeg RemoveItem(int index)
		{
			return default(SVGPathSeg);
		}

		public SVGPathSeg ReplaceItem(SVGPathSeg newItem, int index)
		{
			return default(SVGPathSeg);
		}
	}
}
