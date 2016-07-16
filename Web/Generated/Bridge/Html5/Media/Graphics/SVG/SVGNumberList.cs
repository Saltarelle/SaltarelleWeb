using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGNumberList
	{
		internal extern SVGNumberList();

		[IndexerName("__Item"), FieldProperty]
		public SVGNumber this[int index]
		{
			get;
		}

		public extern SVGNumber AppendItem(SVGNumber newItem);

		public extern void Clear();

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<SVGNumber> GetEnumerator();

		public extern SVGNumber GetItem(int index);

		public extern SVGNumber Initialize(SVGNumber newItem);

		public extern SVGNumber InsertItemBefore(SVGNumber newItem, int index);

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

		public extern SVGNumber RemoveItem(int index);

		public extern SVGNumber ReplaceItem(SVGNumber newItem, int index);
	}
}
