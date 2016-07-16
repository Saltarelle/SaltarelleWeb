namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'AREA'"), Name("Element")]
	public partial class AreaElement : Element
	{
		internal extern AreaElement();

		public extern void AddEventListener(AreaElementEvents type, Action listener);

		public extern void AddEventListener(AreaElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(AreaElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AreaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AreaElementEvents type, HtmlEventHandlerWithTarget<AreaElement> listener);

		public extern void AddEventListener(AreaElementEvents type, HtmlEventHandlerWithTarget<AreaElement> listener, bool capture);

		public extern void AddEventListener(AreaElementEvents type, IEventListener listener);

		public extern void AddEventListener(AreaElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AreaElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AreaElement> listener, bool capture);

		[FieldProperty]
		public extern string Alt
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
		public extern bool NoHref
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

		public extern void RemoveEventListener(AreaElementEvents type, Action listener);

		public extern void RemoveEventListener(AreaElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AreaElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AreaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AreaElementEvents type, HtmlEventHandlerWithTarget<AreaElement> listener);

		public extern void RemoveEventListener(AreaElementEvents type, HtmlEventHandlerWithTarget<AreaElement> listener, bool capture);

		public extern void RemoveEventListener(AreaElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(AreaElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AreaElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AreaElement> listener, bool capture);

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
		public extern string Username
		{
			get;
			set;
		}
	}
}
