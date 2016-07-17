namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGFEGaussianBlurElement : SVGElement
	{
		internal extern SVGFEGaussianBlurElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener, bool capture);

		public extern void AddEventListener(SVGFEGaussianBlurElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEGaussianBlurElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEGaussianBlurElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEGaussianBlurElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEGaussianBlurElementEvents type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener);

		public extern void AddEventListener(SVGFEGaussianBlurElementEvents type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener, bool capture);

		public extern void AddEventListener(SVGFEGaussianBlurElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEGaussianBlurElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEGaussianBlurElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEGaussianBlurElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEGaussianBlurElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEGaussianBlurElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEGaussianBlurElementEvents type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener);

		public extern void RemoveEventListener(SVGFEGaussianBlurElementEvents type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEGaussianBlurElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEGaussianBlurElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		public extern void SetStdDeviation(double stdDeviationX, double stdDeviationY);

		public readonly SVGAnimatedNumber StdDeviationX;

		public readonly SVGAnimatedNumber StdDeviationY;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
