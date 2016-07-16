namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFEImageElement : SVGElement
	{
		internal extern SVGFEImageElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEImageElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEImageElement> listener, bool capture);

		public extern void AddEventListener(SVGFEImageElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEImageElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEImageElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEImageElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEImageElementEvents type, HtmlEventHandlerWithTarget<SVGFEImageElement> listener);

		public extern void AddEventListener(SVGFEImageElementEvents type, HtmlEventHandlerWithTarget<SVGFEImageElement> listener, bool capture);

		public extern void AddEventListener(SVGFEImageElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEImageElementEvents type, IEventListener listener, bool capture);

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

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEImageElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEImageElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEImageElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEImageElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEImageElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEImageElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEImageElementEvents type, HtmlEventHandlerWithTarget<SVGFEImageElement> listener);

		public extern void RemoveEventListener(SVGFEImageElementEvents type, HtmlEventHandlerWithTarget<SVGFEImageElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEImageElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEImageElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedString Result
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
