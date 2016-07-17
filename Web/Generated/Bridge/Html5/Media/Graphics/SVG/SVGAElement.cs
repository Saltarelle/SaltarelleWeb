namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
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

		public string Download;

		public readonly SVGAnimatedString Href;

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

		public readonly SVGAnimatedString Target;
	}
}
