namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGFEOffsetElement : SVGElement
	{
		internal extern SVGFEOffsetElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener, bool capture);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener, bool capture);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedNumber Dx;

		public readonly SVGAnimatedNumber Dy;

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
