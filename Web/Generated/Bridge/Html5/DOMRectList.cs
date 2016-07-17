namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMRectList
	{
		internal extern DOMRectList();

		[IndexerName("__Item"), FieldProperty]
		public DOMRect this[int index]
		{
			get;
		}

		public extern DOMRect Item(int index);

		public readonly int Length;
	}
}
