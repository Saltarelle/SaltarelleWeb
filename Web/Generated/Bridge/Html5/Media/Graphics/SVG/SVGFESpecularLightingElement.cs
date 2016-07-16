namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFESpecularLightingElement : SVGElement
	{
		internal extern SVGFESpecularLightingElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFESpecularLightingElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFESpecularLightingElement> listener, bool capture);

		public extern void AddEventListener(SVGFESpecularLightingElementEvents type, Action listener);

		public extern void AddEventListener(SVGFESpecularLightingElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFESpecularLightingElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFESpecularLightingElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFESpecularLightingElementEvents type, HtmlEventHandlerWithTarget<SVGFESpecularLightingElement> listener);

		public extern void AddEventListener(SVGFESpecularLightingElementEvents type, HtmlEventHandlerWithTarget<SVGFESpecularLightingElement> listener, bool capture);

		public extern void AddEventListener(SVGFESpecularLightingElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFESpecularLightingElementEvents type, IEventListener listener, bool capture);

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

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFESpecularLightingElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFESpecularLightingElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFESpecularLightingElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFESpecularLightingElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFESpecularLightingElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFESpecularLightingElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFESpecularLightingElementEvents type, HtmlEventHandlerWithTarget<SVGFESpecularLightingElement> listener);

		public extern void RemoveEventListener(SVGFESpecularLightingElementEvents type, HtmlEventHandlerWithTarget<SVGFESpecularLightingElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFESpecularLightingElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFESpecularLightingElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedString Result
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber SpecularConstant
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber SpecularExponent
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
