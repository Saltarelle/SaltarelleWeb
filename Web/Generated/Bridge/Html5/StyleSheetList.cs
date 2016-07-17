namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class StyleSheetList
	{
		internal extern StyleSheetList();

		public extern StyleSheet this[int index]
		{
			get;
		}

		public extern StyleSheet Item(int index);

		public readonly int Length;
	}
}
