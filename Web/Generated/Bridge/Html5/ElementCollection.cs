namespace Bridge.Html5
{
	[Namespace("false"), External, Name("HTMLCollection")]
	public partial class ElementCollection
	{
		internal extern ElementCollection();

		public extern Element this[int index]
		{
			get;
		}

		public extern Element this[string name]
		{
			get;
		}

		public extern Element Item(int index);

		public readonly int Length;

		public extern Element NamedItem(string name);
	}
}
