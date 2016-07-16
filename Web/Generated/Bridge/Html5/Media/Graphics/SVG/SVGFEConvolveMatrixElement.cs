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

		[FieldProperty]
		public extern SVGAnimatedNumber Bias
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Divisor
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGFEConvolveMatrixEdgeMode> EdgeMode
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
		public extern SVGAnimatedNumberList KernelMatrix
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

		[FieldProperty]
		public extern SVGAnimatedInteger OrderX
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedInteger OrderY
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedBoolean PreserveAlpha
		{
			get;
		}

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

		[FieldProperty]
		public extern SVGAnimatedString Result
		{
			get;
		}

		[Name("SVG_EDGEMODE_DUPLICATE")]
		public const ushort SVG_EDGEMODE_DUPLICATE = 1;

		[Name("SVG_EDGEMODE_NONE")]
		public const ushort SVG_EDGEMODE_NONE = 3;

		[Name("SVG_EDGEMODE_UNKNOWN")]
		public const ushort SVG_EDGEMODE_UNKNOWN = 0;

		[Name("SVG_EDGEMODE_WRAP")]
		public const ushort SVG_EDGEMODE_WRAP = 2;

		[FieldProperty]
		public extern SVGAnimatedInteger TargetX
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedInteger TargetY
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
