namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
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

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString Href;

		public readonly SVGAnimatedPreserveAspectRatio PreserveAspectRatio;

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

		public readonly SVGAnimatedString Result;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
