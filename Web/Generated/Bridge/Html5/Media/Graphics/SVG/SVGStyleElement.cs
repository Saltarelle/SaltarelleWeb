namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGStyleElement : SVGElement
	{
		internal extern SVGStyleElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGStyleElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGStyleElement> listener, bool capture);

		public extern void AddEventListener(SVGStyleElementEvents type, Action listener);

		public extern void AddEventListener(SVGStyleElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGStyleElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGStyleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGStyleElementEvents type, HtmlEventHandlerWithTarget<SVGStyleElement> listener);

		public extern void AddEventListener(SVGStyleElementEvents type, HtmlEventHandlerWithTarget<SVGStyleElement> listener, bool capture);

		public extern void AddEventListener(SVGStyleElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGStyleElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern string Media
		{
			get;
			set;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGStyleElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGStyleElement> listener, bool capture);

		public extern void RemoveEventListener(SVGStyleElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGStyleElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGStyleElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGStyleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGStyleElementEvents type, HtmlEventHandlerWithTarget<SVGStyleElement> listener);

		public extern void RemoveEventListener(SVGStyleElementEvents type, HtmlEventHandlerWithTarget<SVGStyleElement> listener, bool capture);

		public extern void RemoveEventListener(SVGStyleElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGStyleElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern bool Scoped
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Title
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
		public extern string Xmlspace
		{
			get;
			set;
		}
	}
}
