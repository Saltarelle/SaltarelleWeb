namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class StyleSheetList
	{
		internal extern StyleSheetList();

		[IndexerName("__Item"), FieldProperty]
		public StyleSheet this[int index]
		{
			get;
		}

		public extern StyleSheet Item(int index);

		public readonly int Length;
	}
}
