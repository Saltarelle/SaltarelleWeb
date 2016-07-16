namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern SVGAnimatedNumber Dx
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Dy
		{
			get;
		}

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
