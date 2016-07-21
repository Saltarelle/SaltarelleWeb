using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("HTMLFormControlsCollection")]
	public partial class FormControlsCollection : HTMLCollection
	{
		internal extern FormControlsCollection();

		public extern TypeOption<HTMLCollection, HTMLElement> this[string name]
		{
			get;
		}

		public extern TypeOption<HTMLCollection, HTMLElement> NamedItem(string name);
	}
}
