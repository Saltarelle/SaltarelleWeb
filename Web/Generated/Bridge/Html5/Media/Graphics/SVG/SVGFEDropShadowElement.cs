namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGFEDropShadowElement : SVGElement
	{
		internal extern SVGFEDropShadowElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDropShadowElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDropShadowElement> listener, bool capture);

		public extern void AddEventListener(SVGFEDropShadowElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEDropShadowElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEDropShadowElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEDropShadowElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEDropShadowElementEvents type, HtmlEventHandlerWithTarget<SVGFEDropShadowElement> listener);

		public extern void AddEventListener(SVGFEDropShadowElementEvents type, HtmlEventHandlerWithTarget<SVGFEDropShadowElement> listener, bool capture);

		public extern void AddEventListener(SVGFEDropShadowElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEDropShadowElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedNumber Dx;

		public readonly SVGAnimatedNumber Dy;

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDropShadowElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDropShadowElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEDropShadowElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEDropShadowElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEDropShadowElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEDropShadowElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEDropShadowElementEvents type, HtmlEventHandlerWithTarget<SVGFEDropShadowElement> listener);

		public extern void RemoveEventListener(SVGFEDropShadowElementEvents type, HtmlEventHandlerWithTarget<SVGFEDropShadowElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEDropShadowElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEDropShadowElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		public extern void SetStdDeviation(double stdDeviationX, double stdDeviationY);

		public readonly SVGAnimatedNumber StdDeviationX;

		public readonly SVGAnimatedNumber StdDeviationY;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
