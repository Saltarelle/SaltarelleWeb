namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGStopElement : SVGElement
	{
		internal extern SVGStopElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGStopElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGStopElement> listener, bool capture);

		public extern void AddEventListener(SVGStopElementEvents type, Action listener);

		public extern void AddEventListener(SVGStopElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGStopElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGStopElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGStopElementEvents type, HtmlEventHandlerWithTarget<SVGStopElement> listener);

		public extern void AddEventListener(SVGStopElementEvents type, HtmlEventHandlerWithTarget<SVGStopElement> listener, bool capture);

		public extern void AddEventListener(SVGStopElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGStopElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedNumber Offset;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGStopElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGStopElement> listener, bool capture);

		public extern void RemoveEventListener(SVGStopElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGStopElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGStopElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGStopElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGStopElementEvents type, HtmlEventHandlerWithTarget<SVGStopElement> listener);

		public extern void RemoveEventListener(SVGStopElementEvents type, HtmlEventHandlerWithTarget<SVGStopElement> listener, bool capture);

		public extern void RemoveEventListener(SVGStopElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGStopElementEvents type, IEventListener listener, bool capture);
	}
}
