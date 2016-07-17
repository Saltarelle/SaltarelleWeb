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

		public extern string GetItem(int index);

		public extern string Initialize(string newItem);

		public extern string InsertItemBefore(string newItem, int index);

		public readonly int Length;

		public readonly int NumberOfItems;

		public extern string RemoveItem(int index);

		public extern string ReplaceItem(string newItem, int index);
	}
}
