namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGAElement : SVGGraphicsElement
	{
		internal extern SVGAElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAElement> listener, bool capture);

		public extern void AddEventListener(SVGAElementEvents type, Action listener);

		public extern void AddEventListener(SVGAElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGAElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGAElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGAElementEvents type, HtmlEventHandlerWithTarget<SVGAElement> listener);

		public extern void AddEventListener(SVGAElementEvents type, HtmlEventHandlerWithTarget<SVGAElement> listener, bool capture);

		public extern void AddEventListener(SVGAElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGAElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern string Download
		{
			get;
			set;
		}

		[FieldProperty]
		public extern SVGAnimatedString Href
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAElement> listener, bool capture);

		public extern void RemoveEventListener(SVGAElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGAElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGAElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGAElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGAElementEvents type, HtmlEventHandlerWithTarget<SVGAElement> listener);

		public extern void RemoveEventListener(SVGAElementEvents type, HtmlEventHandlerWithTarget<SVGAElement> listener, bool capture);

		public extern void RemoveEventListener(SVGAElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGAElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedString Target
		{
			get;
		}
	}
}
