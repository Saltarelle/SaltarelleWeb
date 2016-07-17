namespace Bridge.Html5
{
	[Namespace("false"), External, Name("HTMLFormControlsCollection")]
	public partial class FormControlsCollection : ElementCollection
	{
		internal extern FormControlsCollection();

		[IndexerName("__Item"), FieldProperty]
		public TypeOption<ElementNodeList, Element> this[string name]
		{
			get;
		}

		public extern TypeOption<ElementNodeList, Element> NamedItem(string name);
	}
}
