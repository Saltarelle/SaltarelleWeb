namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFEMorphologyElement : SVGElement
	{
		internal extern SVGFEMorphologyElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEMorphologyElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEMorphologyElement> listener, bool capture);

		public extern void AddEventListener(SVGFEMorphologyElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEMorphologyElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEMorphologyElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEMorphologyElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEMorphologyElementEvents type, HtmlEventHandlerWithTarget<SVGFEMorphologyElement> listener);

		public extern void AddEventListener(SVGFEMorphologyElementEvents type, HtmlEventHandlerWithTarget<SVGFEMorphologyElement> listener, bool capture);

		public extern void AddEventListener(SVGFEMorphologyElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEMorphologyElementEvents type, IEventListener listener, bool capture);

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
		public extern SVGAnimatedEnumeration<SVGFEMorphologyOperator> Operator
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber RadiusX
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber RadiusY
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEMorphologyElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEMorphologyElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEMorphologyElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEMorphologyElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEMorphologyElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEMorphologyElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEMorphologyElementEvents type, HtmlEventHandlerWithTarget<SVGFEMorphologyElement> listener);

		public extern void RemoveEventListener(SVGFEMorphologyElementEvents type, HtmlEventHandlerWithTarget<SVGFEMorphologyElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEMorphologyElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEMorphologyElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedString Result
		{
			get;
		}

		[Name("SVG_MORPHOLOGY_OPERATOR_DILATE")]
		public const ushort SVG_MORPHOLOGY_OPERATOR_DILATE = 2;

		[Name("SVG_MORPHOLOGY_OPERATOR_ERODE")]
		public const ushort SVG_MORPHOLOGY_OPERATOR_ERODE = 1;

		[Name("SVG_MORPHOLOGY_OPERATOR_UNKNOWN")]
		public const ushort SVG_MORPHOLOGY_OPERATOR_UNKNOWN = 0;

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
