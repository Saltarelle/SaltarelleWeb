namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFEConvolveMatrixElement : SVGElement
	{
		internal extern SVGFEConvolveMatrixElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEConvolveMatrixElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEConvolveMatrixElement> listener, bool capture);

		public extern void AddEventListener(SVGFEConvolveMatrixElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEConvolveMatrixElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEConvolveMatrixElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEConvolveMatrixElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEConvolveMatrixElementEvents type, HtmlEventHandlerWithTarget<SVGFEConvolveMatrixElement> listener);

		public extern void AddEventListener(SVGFEConvolveMatrixElementEvents type, HtmlEventHandlerWithTarget<SVGFEConvolveMatrixElement> listener, bool capture);

		public extern void AddEventListener(SVGFEConvolveMatrixElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEConvolveMatrixElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedNumber Bias;

		public readonly SVGAnimatedNumber Divisor;

		public readonly SVGAnimatedEnumeration<SVGFEConvolveMatrixEdgeMode> EdgeMode;

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public readonly SVGAnimatedNumberList KernelMatrix;

		public readonly SVGAnimatedNumber KernelUnitLengthX;

		public readonly SVGAnimatedNumber KernelUnitLengthY;

		public readonly SVGAnimatedInteger OrderX;

		public readonly SVGAnimatedInteger OrderY;

		public readonly SVGAnimatedBoolean PreserveAlpha;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEConvolveMatrixElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEConvolveMatrixElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEConvolveMatrixElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEConvolveMatrixElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEConvolveMatrixElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEConvolveMatrixElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEConvolveMatrixElementEvents type, HtmlEventHandlerWithTarget<SVGFEConvolveMatrixElement> listener);

		public extern void RemoveEventListener(SVGFEConvolveMatrixElementEvents type, HtmlEventHandlerWithTarget<SVGFEConvolveMatrixElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEConvolveMatrixElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEConvolveMatrixElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		[Name("SVG_EDGEMODE_DUPLICATE")]
		public const ushort SVG_EDGEMODE_DUPLICATE = 1;

		[Name("SVG_EDGEMODE_NONE")]
		public const ushort SVG_EDGEMODE_NONE = 3;

		[Name("SVG_EDGEMODE_UNKNOWN")]
		public const ushort SVG_EDGEMODE_UNKNOWN = 0;

		[Name("SVG_EDGEMODE_WRAP")]
		public const ushort SVG_EDGEMODE_WRAP = 2;

		public readonly SVGAnimatedInteger TargetX;

		public readonly SVGAnimatedInteger TargetY;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
