namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGImageElement : SVGGraphicsElement
	{
		internal extern SVGImageElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGImageElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGImageElement> listener, bool capture);

		public extern void AddEventListener(SVGImageElementEvents type, Action listener);

		public extern void AddEventListener(SVGImageElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGImageElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGImageElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGImageElementEvents type, HtmlEventHandlerWithTarget<SVGImageElement> listener);

		public extern void AddEventListener(SVGImageElementEvents type, HtmlEventHandlerWithTarget<SVGImageElement> listener, bool capture);

		public extern void AddEventListener(SVGImageElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGImageElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedLength Height
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedString Href
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedPreserveAspectRatio PreserveAspectRatio
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGImageElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGImageElement> listener, bool capture);

		public extern void RemoveEventListener(SVGImageElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGImageElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGImageElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGImageElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGImageElementEvents type, HtmlEventHandlerWithTarget<SVGImageElement> listener);

		public extern void RemoveEventListener(SVGImageElementEvents type, HtmlEventHandlerWithTarget<SVGImageElement> listener, bool capture);

		public extern void RemoveEventListener(SVGImageElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGImageElementEvents type, IEventListener listener, bool capture);

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
