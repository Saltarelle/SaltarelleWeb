namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("HTMLFormControlsCollection")]
	public partial class FormControlsCollection : ElementCollection
	{
		internal FormControlsCollection()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public TypeOption<ElementNodeList, Element> this[string name]
		{
			get {
				return default(TypeOption<ElementNodeList, Element>);
			}
		}

		public TypeOption<ElementNodeList, Element> NamedItem(string name)
		{
			return default(TypeOption<ElementNodeList, Element>);
		}
	}
}
