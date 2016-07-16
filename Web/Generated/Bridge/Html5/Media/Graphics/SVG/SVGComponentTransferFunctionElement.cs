namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGComponentTransferFunctionElement : SVGElement
	{
		internal extern SVGComponentTransferFunctionElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGComponentTransferFunctionElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGComponentTransferFunctionElement> listener, bool capture);

		public extern void AddEventListener(SVGComponentTransferFunctionElementEvents type, Action listener);

		public extern void AddEventListener(SVGComponentTransferFunctionElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGComponentTransferFunctionElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGComponentTransferFunctionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGComponentTransferFunctionElementEvents type, HtmlEventHandlerWithTarget<SVGComponentTransferFunctionElement> listener);

		public extern void AddEventListener(SVGComponentTransferFunctionElementEvents type, HtmlEventHandlerWithTarget<SVGComponentTransferFunctionElement> listener, bool capture);

		public extern void AddEventListener(SVGComponentTransferFunctionElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGComponentTransferFunctionElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedNumber Amplitude
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Exponent
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Intercept
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Offset
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGComponentTransferFunctionElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGComponentTransferFunctionElement> listener, bool capture);

		public extern void RemoveEventListener(SVGComponentTransferFunctionElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGComponentTransferFunctionElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGComponentTransferFunctionElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGComponentTransferFunctionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGComponentTransferFunctionElementEvents type, HtmlEventHandlerWithTarget<SVGComponentTransferFunctionElement> listener);

		public extern void RemoveEventListener(SVGComponentTransferFunctionElementEvents type, HtmlEventHandlerWithTarget<SVGComponentTransferFunctionElement> listener, bool capture);

		public extern void RemoveEventListener(SVGComponentTransferFunctionElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGComponentTransferFunctionElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedNumber Slope
		{
			get;
		}

		[Name("SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE = 3;

		[Name("SVG_FECOMPONENTTRANSFER_TYPE_GAMMA")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_GAMMA = 5;

		[Name("SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY = 1;

		[Name("SVG_FECOMPONENTTRANSFER_TYPE_LINEAR")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_LINEAR = 4;

		[Name("SVG_FECOMPONENTTRANSFER_TYPE_TABLE")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_TABLE = 2;

		[Name("SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN")]
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN = 0;

		[FieldProperty]
		public extern SVGAnimatedNumberList TableValues
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGComponentTransferType> Type
		{
			get;
		}
	}
}
