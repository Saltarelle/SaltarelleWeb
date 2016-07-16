using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGStringList
	{
		internal SVGStringList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public string this[int index]
		{
			get {
				return null;
			}
		}

		public string AppendItem(string newItem)
		{
			return null;
		}

		public void Clear()
		{
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		public string GetItem(int index)
		{
			return null;
		}

		public string Initialize(string newItem)
		{
			return null;
		}

		public string InsertItemBefore(string newItem, int index)
		{
			return null;
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

		public string RemoveItem(int index)
		{
			return null;
		}

		public string ReplaceItem(string newItem, int index)
		{
			return null;
		}
	}
}
