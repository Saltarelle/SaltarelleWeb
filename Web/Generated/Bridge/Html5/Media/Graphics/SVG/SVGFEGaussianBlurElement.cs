namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern SVGAnimatedLength Height
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedString In1
		{
			get;
		}

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

		[FieldProperty]
		public extern SVGAnimatedString Result
		{
			get;
		}

		public extern void SetStdDeviation(double stdDeviationX, double stdDeviationY);

		[FieldProperty]
		public extern SVGAnimatedNumber StdDeviationX
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber StdDeviationY
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Width
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength X
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Y
		{
			get;
		}
	}
}
