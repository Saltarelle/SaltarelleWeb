namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGFECompositeElement : SVGElement
	{
		internal extern SVGFECompositeElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFECompositeElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFECompositeElement> listener, bool capture);

		public extern void AddEventListener(SVGFECompositeElementEvents type, Action listener);

		public extern void AddEventListener(SVGFECompositeElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFECompositeElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFECompositeElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFECompositeElementEvents type, HtmlEventHandlerWithTarget<SVGFECompositeElement> listener);

		public extern void AddEventListener(SVGFECompositeElementEvents type, HtmlEventHandlerWithTarget<SVGFECompositeElement> listener, bool capture);

		public extern void AddEventListener(SVGFECompositeElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFECompositeElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public readonly SVGAnimatedString In2;

		public readonly SVGAnimatedNumber K1;

		public readonly SVGAnimatedNumber K2;

		public readonly SVGAnimatedNumber K3;

		public readonly SVGAnimatedNumber K4;

		public readonly SVGAnimatedEnumeration<SVGFECompositeOperator> Operator;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFECompositeElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFECompositeElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFECompositeElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFECompositeElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFECompositeElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFECompositeElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFECompositeElementEvents type, HtmlEventHandlerWithTarget<SVGFECompositeElement> listener);

		public extern void RemoveEventListener(SVGFECompositeElementEvents type, HtmlEventHandlerWithTarget<SVGFECompositeElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFECompositeElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFECompositeElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		[Name("SVG_FECOMPOSITE_OPERATOR_ARITHMETIC")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_ARITHMETIC = 6;

		[Name("SVG_FECOMPOSITE_OPERATOR_ATOP")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_ATOP = 4;

		[Name("SVG_FECOMPOSITE_OPERATOR_IN")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_IN = 2;

		[Name("SVG_FECOMPOSITE_OPERATOR_OUT")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_OUT = 3;

		[Name("SVG_FECOMPOSITE_OPERATOR_OVER")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_OVER = 1;

		[Name("SVG_FECOMPOSITE_OPERATOR_UNKNOWN")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_UNKNOWN = 0;

		[Name("SVG_FECOMPOSITE_OPERATOR_XOR")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_XOR = 5;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
