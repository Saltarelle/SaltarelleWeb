namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class StyleElement : Element
	{
		internal extern StyleElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<StyleElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<StyleElement> listener, bool capture);

		public extern void AddEventListener(StyleElementEvents type, Action listener);

		public extern void AddEventListener(StyleElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(StyleElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(StyleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(StyleElementEvents type, HtmlEventHandlerWithTarget<StyleElement> listener);

		public extern void AddEventListener(StyleElementEvents type, HtmlEventHandlerWithTarget<StyleElement> listener, bool capture);

		public extern void AddEventListener(StyleElementEvents type, IEventListener listener);

		public extern void AddEventListener(StyleElementEvents type, IEventListener listener, bool capture);

		public bool Disabled;

		public string Media;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<StyleElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<StyleElement> listener, bool capture);

		public extern void RemoveEventListener(StyleElementEvents type, Action listener);

		public extern void RemoveEventListener(StyleElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(StyleElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(StyleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(StyleElementEvents type, HtmlEventHandlerWithTarget<StyleElement> listener);

		public extern void RemoveEventListener(StyleElementEvents type, HtmlEventHandlerWithTarget<StyleElement> listener, bool capture);

		public extern void RemoveEventListener(StyleElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(StyleElementEvents type, IEventListener listener, bool capture);

		public bool Scoped;

		public readonly StyleSheet Sheet;

		public string Type;
	}
}
