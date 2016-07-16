namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFEDiffuseLightingElement : SVGElement
	{
		internal extern SVGFEDiffuseLightingElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDiffuseLightingElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDiffuseLightingElement> listener, bool capture);

		public extern void AddEventListener(SVGFEDiffuseLightingElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEDiffuseLightingElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEDiffuseLightingElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEDiffuseLightingElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEDiffuseLightingElementEvents type, HtmlEventHandlerWithTarget<SVGFEDiffuseLightingElement> listener);

		public extern void AddEventListener(SVGFEDiffuseLightingElementEvents type, HtmlEventHandlerWithTarget<SVGFEDiffuseLightingElement> listener, bool capture);

		public extern void AddEventListener(SVGFEDiffuseLightingElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEDiffuseLightingElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedNumber DiffuseConstant
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

		[FieldProperty]
		public extern SVGAnimatedNumber KernelUnitLengthX
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber KernelUnitLengthY
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDiffuseLightingElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDiffuseLightingElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEDiffuseLightingElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEDiffuseLightingElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEDiffuseLightingElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEDiffuseLightingElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEDiffuseLightingElementEvents type, HtmlEventHandlerWithTarget<SVGFEDiffuseLightingElement> listener);

		public extern void RemoveEventListener(SVGFEDiffuseLightingElementEvents type, HtmlEventHandlerWithTarget<SVGFEDiffuseLightingElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEDiffuseLightingElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEDiffuseLightingElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedString Result
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber SurfaceScale
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
