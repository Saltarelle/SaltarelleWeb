using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGStringList
	{
		internal extern SVGStringList();

		[IndexerName("__Item"), FieldProperty]
		public string this[int index]
		{
			get;
		}

		public extern string AppendItem(string newItem);

		public extern void Clear();

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<string> GetEnumerator();

		public extern string GetItem(int index);

		public extern string Initialize(string newItem);

		public extern string InsertItemBefore(string newItem, int index);

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

		public extern string RemoveItem(int index);

		public extern string ReplaceItem(string newItem, int index);
	}
}
