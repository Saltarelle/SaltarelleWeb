namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGUseElement : SVGGraphicsElement
	{
		internal extern SVGUseElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGUseElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGUseElement> listener, bool capture);

		public extern void AddEventListener(SVGUseElementEvents type, Action listener);

		public extern void AddEventListener(SVGUseElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGUseElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGUseElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGUseElementEvents type, HtmlEventHandlerWithTarget<SVGUseElement> listener);

		public extern void AddEventListener(SVGUseElementEvents type, HtmlEventHandlerWithTarget<SVGUseElement> listener, bool capture);

		public extern void AddEventListener(SVGUseElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGUseElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString Href;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGUseElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGUseElement> listener, bool capture);

		public extern void RemoveEventListener(SVGUseElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGUseElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGUseElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGUseElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGUseElementEvents type, HtmlEventHandlerWithTarget<SVGUseElement> listener);

		public extern void RemoveEventListener(SVGUseElementEvents type, HtmlEventHandlerWithTarget<SVGUseElement> listener, bool capture);

		public extern void RemoveEventListener(SVGUseElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGUseElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
