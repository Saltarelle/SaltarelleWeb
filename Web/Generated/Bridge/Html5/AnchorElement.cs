namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'A'"), Name("Element")]
	public partial class AnchorElement : Element
	{
		internal extern AnchorElement();

		public extern void AddEventListener(AnchorElementEvents type, Action listener);

		public extern void AddEventListener(AnchorElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(AnchorElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AnchorElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AnchorElementEvents type, HtmlEventHandlerWithTarget<AnchorElement> listener);

		public extern void AddEventListener(AnchorElementEvents type, HtmlEventHandlerWithTarget<AnchorElement> listener, bool capture);

		public extern void AddEventListener(AnchorElementEvents type, IEventListener listener);

		public extern void AddEventListener(AnchorElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AnchorElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AnchorElement> listener, bool capture);

		[FieldProperty]
		public extern string Charset
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Coords
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Download
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Hash
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Host
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Hostname
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
		public extern string Name
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Origin
		{
			get;
		}

		[FieldProperty]
		public extern string Password
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Pathname
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Ping
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Port
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Protocol
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

		public extern void RemoveEventListener(AnchorElementEvents type, Action listener);

		public extern void RemoveEventListener(AnchorElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AnchorElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AnchorElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AnchorElementEvents type, HtmlEventHandlerWithTarget<AnchorElement> listener);

		public extern void RemoveEventListener(AnchorElementEvents type, HtmlEventHandlerWithTarget<AnchorElement> listener, bool capture);

		public extern void RemoveEventListener(AnchorElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(AnchorElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AnchorElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AnchorElement> listener, bool capture);

		[FieldProperty]
		public extern string Rev
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Search
		{
			get;
			set;
		}

		[FieldProperty]
		public extern URLSearchParams SearchParams
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Shape
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Target
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Text
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

		[FieldProperty]
		public extern string Username
		{
			get;
			set;
		}
	}
}
