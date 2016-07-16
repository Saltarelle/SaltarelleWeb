namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'LINK'"), Name("Element")]
	public partial class LinkElement : Element
	{
		internal extern LinkElement();

		public extern void AddEventListener(LinkElementEvents type, Action listener);

		public extern void AddEventListener(LinkElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(LinkElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(LinkElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(LinkElementEvents type, HtmlEventHandlerWithTarget<LinkElement> listener);

		public extern void AddEventListener(LinkElementEvents type, HtmlEventHandlerWithTarget<LinkElement> listener, bool capture);

		public extern void AddEventListener(LinkElementEvents type, IEventListener listener);

		public extern void AddEventListener(LinkElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<LinkElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<LinkElement> listener, bool capture);

		[FieldProperty]
		public extern string Charset
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string CrossOrigin
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Disabled
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Href
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Hreflang
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

		[FieldProperty]
		public extern string Rel
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TokenList RelList
		{
			get;
		}

		public extern void RemoveEventListener(LinkElementEvents type, Action listener);

		public extern void RemoveEventListener(LinkElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(LinkElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(LinkElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(LinkElementEvents type, HtmlEventHandlerWithTarget<LinkElement> listener);

		public extern void RemoveEventListener(LinkElementEvents type, HtmlEventHandlerWithTarget<LinkElement> listener, bool capture);

		public extern void RemoveEventListener(LinkElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(LinkElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LinkElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LinkElement> listener, bool capture);

		[FieldProperty]
		public extern string Rev
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
		public extern string Target
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
			set;
		}
	}
}
