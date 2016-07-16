using System.Collections.Generic;

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

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<SVGLength> GetEnumerator();

		public extern SVGLength GetItem(int index);

		public extern SVGLength Initialize(SVGLength newItem);

		public extern SVGLength InsertItemBefore(SVGLength newItem, int index);

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

		public extern SVGLength RemoveItem(int index);

		public extern SVGLength ReplaceItem(SVGLength newItem, int index);
	}
}
