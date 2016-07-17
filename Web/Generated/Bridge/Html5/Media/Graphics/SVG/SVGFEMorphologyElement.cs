namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
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

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public readonly SVGAnimatedEnumeration<SVGFEMorphologyOperator> Operator;

		public readonly SVGAnimatedNumber RadiusX;

		public readonly SVGAnimatedNumber RadiusY;

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

		public readonly SVGAnimatedString Result;

		[Name("SVG_MORPHOLOGY_OPERATOR_DILATE")]
		public const ushort SVG_MORPHOLOGY_OPERATOR_DILATE = 2;

		[Name("SVG_MORPHOLOGY_OPERATOR_ERODE")]
		public const ushort SVG_MORPHOLOGY_OPERATOR_ERODE = 1;

		[Name("SVG_MORPHOLOGY_OPERATOR_UNKNOWN")]
		public const ushort SVG_MORPHOLOGY_OPERATOR_UNKNOWN = 0;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
