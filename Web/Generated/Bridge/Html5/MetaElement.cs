namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class MetaElement : Element
	{
		internal extern MetaElement();

		public extern void AddEventListener(MetaElementEvents type, Action listener);

		public extern void AddEventListener(MetaElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(MetaElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MetaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MetaElementEvents type, HtmlEventHandlerWithTarget<MetaElement> listener);

		public extern void AddEventListener(MetaElementEvents type, HtmlEventHandlerWithTarget<MetaElement> listener, bool capture);

		public extern void AddEventListener(MetaElementEvents type, IEventListener listener);

		public extern void AddEventListener(MetaElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MetaElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MetaElement> listener, bool capture);

		public string Content;

		public string HttpEquiv;

		public string Name;

		public extern void RemoveEventListener(MetaElementEvents type, Action listener);

		public extern void RemoveEventListener(MetaElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MetaElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MetaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MetaElementEvents type, HtmlEventHandlerWithTarget<MetaElement> listener);

		public extern void RemoveEventListener(MetaElementEvents type, HtmlEventHandlerWithTarget<MetaElement> listener, bool capture);

		public extern void RemoveEventListener(MetaElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(MetaElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MetaElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MetaElement> listener, bool capture);

		public string Scheme;
	}
}
