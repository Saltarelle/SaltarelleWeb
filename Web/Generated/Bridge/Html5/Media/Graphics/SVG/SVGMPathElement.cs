namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGMPathElement : SVGElement
	{
		internal extern SVGMPathElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGMPathElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGMPathElement> listener, bool capture);

		public extern void AddEventListener(SVGMPathElementEvents type, Action listener);

		public extern void AddEventListener(SVGMPathElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGMPathElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGMPathElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGMPathElementEvents type, HtmlEventHandlerWithTarget<SVGMPathElement> listener);

		public extern void AddEventListener(SVGMPathElementEvents type, HtmlEventHandlerWithTarget<SVGMPathElement> listener, bool capture);

		public extern void AddEventListener(SVGMPathElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGMPathElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Href;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGMPathElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGMPathElement> listener, bool capture);

		public extern void RemoveEventListener(SVGMPathElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGMPathElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGMPathElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGMPathElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGMPathElementEvents type, HtmlEventHandlerWithTarget<SVGMPathElement> listener);

		public extern void RemoveEventListener(SVGMPathElementEvents type, HtmlEventHandlerWithTarget<SVGMPathElement> listener, bool capture);

		public extern void RemoveEventListener(SVGMPathElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGMPathElementEvents type, IEventListener listener, bool capture);
	}
}
