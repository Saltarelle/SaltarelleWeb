using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGStringList : IEnumerable<string>
	{
		internal extern SVGStringList();

		public extern string this[int index]
		{
			get;
		}

		public extern string AppendItem(string newItem);

		public extern void Clear();

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<string> GetEnumerator();

		public extern string GetItem(int index);

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern string Initialize(string newItem);

		public extern string InsertItemBefore(string newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern string RemoveItem(int index);

		public extern string ReplaceItem(string newItem, int index);
	}
}
