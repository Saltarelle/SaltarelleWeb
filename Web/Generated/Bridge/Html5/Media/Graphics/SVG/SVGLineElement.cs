namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGLineElement : SVGGraphicsElement
	{
		internal extern SVGLineElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGLineElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGLineElement> listener, bool capture);

		public extern void AddEventListener(SVGLineElementEvents type, Action listener);

		public extern void AddEventListener(SVGLineElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGLineElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGLineElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGLineElementEvents type, HtmlEventHandlerWithTarget<SVGLineElement> listener);

		public extern void AddEventListener(SVGLineElementEvents type, HtmlEventHandlerWithTarget<SVGLineElement> listener, bool capture);

		public extern void AddEventListener(SVGLineElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGLineElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGLineElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGLineElement> listener, bool capture);

		public extern void RemoveEventListener(SVGLineElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGLineElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGLineElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGLineElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGLineElementEvents type, HtmlEventHandlerWithTarget<SVGLineElement> listener);

		public extern void RemoveEventListener(SVGLineElementEvents type, HtmlEventHandlerWithTarget<SVGLineElement> listener, bool capture);

		public extern void RemoveEventListener(SVGLineElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGLineElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedLength X1
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength X2
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Y1
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Y2
		{
			get;
		}
	}
}
