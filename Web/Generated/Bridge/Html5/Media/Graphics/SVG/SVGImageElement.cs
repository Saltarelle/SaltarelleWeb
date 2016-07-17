namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
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

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString Href;

		public readonly SVGAnimatedPreserveAspectRatio PreserveAspectRatio;

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

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
