namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'STYLE'"), Name("Element")]
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

		[FieldProperty]
		public extern bool Disabled
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Media
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern bool Scoped
		{
			get;
			set;
		}

		[FieldProperty]
		public extern StyleSheet Sheet
		{
			get;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
			set;
		}
	}
}
