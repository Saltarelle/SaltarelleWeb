using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGNumberList
	{
		internal SVGNumberList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public SVGNumber this[int index]
		{
			get {
				return default(SVGNumber);
			}
		}

		public SVGNumber AppendItem(SVGNumber newItem)
		{
			return default(SVGNumber);
		}

		public void Clear()
		{
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGNumber> GetEnumerator()
		{
			return null;
		}

		public SVGNumber GetItem(int index)
		{
			return default(SVGNumber);
		}

		public SVGNumber Initialize(SVGNumber newItem)
		{
			return default(SVGNumber);
		}

		public SVGNumber InsertItemBefore(SVGNumber newItem, int index)
		{
			return default(SVGNumber);
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

		public SVGNumber RemoveItem(int index)
		{
			return default(SVGNumber);
		}

		public SVGNumber ReplaceItem(SVGNumber newItem, int index)
		{
			return default(SVGNumber);
		}
	}
}
