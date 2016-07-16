namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGRectElement : SVGGraphicsElement
	{
		internal extern SVGRectElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGRectElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGRectElement> listener, bool capture);

		public extern void AddEventListener(SVGRectElementEvents type, Action listener);

		public extern void AddEventListener(SVGRectElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGRectElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGRectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGRectElementEvents type, HtmlEventHandlerWithTarget<SVGRectElement> listener);

		public extern void AddEventListener(SVGRectElementEvents type, HtmlEventHandlerWithTarget<SVGRectElement> listener, bool capture);

		public extern void AddEventListener(SVGRectElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGRectElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedLength Height
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGRectElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGRectElement> listener, bool capture);

		public extern void RemoveEventListener(SVGRectElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGRectElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGRectElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGRectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGRectElementEvents type, HtmlEventHandlerWithTarget<SVGRectElement> listener);

		public extern void RemoveEventListener(SVGRectElementEvents type, HtmlEventHandlerWithTarget<SVGRectElement> listener, bool capture);

		public extern void RemoveEventListener(SVGRectElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGRectElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedLength Rx
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Ry
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Width
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength X
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Y
		{
			get;
		}
	}
}
