using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGLengthList
	{
		internal SVGLengthList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public SVGLength this[int index]
		{
			get {
				return default(SVGLength);
			}
		}

		public SVGLength AppendItem(SVGLength newItem)
		{
			return default(SVGLength);
		}

		public void Clear()
		{
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGLength> GetEnumerator()
		{
			return null;
		}

		public SVGLength GetItem(int index)
		{
			return default(SVGLength);
		}

		public SVGLength Initialize(SVGLength newItem)
		{
			return default(SVGLength);
		}

		public SVGLength InsertItemBefore(SVGLength newItem, int index)
		{
			return default(SVGLength);
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

		public SVGLength RemoveItem(int index)
		{
			return default(SVGLength);
		}

		public SVGLength ReplaceItem(SVGLength newItem, int index)
		{
			return default(SVGLength);
		}
	}
}
