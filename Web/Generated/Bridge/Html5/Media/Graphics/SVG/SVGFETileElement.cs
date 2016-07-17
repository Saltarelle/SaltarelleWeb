namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGFETileElement : SVGElement
	{
		internal extern SVGFETileElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFETileElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFETileElement> listener, bool capture);

		public extern void AddEventListener(SVGFETileElementEvents type, Action listener);

		public extern void AddEventListener(SVGFETileElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFETileElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFETileElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFETileElementEvents type, HtmlEventHandlerWithTarget<SVGFETileElement> listener);

		public extern void AddEventListener(SVGFETileElementEvents type, HtmlEventHandlerWithTarget<SVGFETileElement> listener, bool capture);

		public extern void AddEventListener(SVGFETileElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFETileElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFETileElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFETileElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFETileElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFETileElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFETileElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFETileElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFETileElementEvents type, HtmlEventHandlerWithTarget<SVGFETileElement> listener);

		public extern void RemoveEventListener(SVGFETileElementEvents type, HtmlEventHandlerWithTarget<SVGFETileElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFETileElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFETileElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
