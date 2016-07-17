namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGFEColorMatrixElement : SVGElement
	{
		internal extern SVGFEColorMatrixElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEColorMatrixElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEColorMatrixElement> listener, bool capture);

		public extern void AddEventListener(SVGFEColorMatrixElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEColorMatrixElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEColorMatrixElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEColorMatrixElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEColorMatrixElementEvents type, HtmlEventHandlerWithTarget<SVGFEColorMatrixElement> listener);

		public extern void AddEventListener(SVGFEColorMatrixElementEvents type, HtmlEventHandlerWithTarget<SVGFEColorMatrixElement> listener, bool capture);

		public extern void AddEventListener(SVGFEColorMatrixElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEColorMatrixElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEColorMatrixElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEColorMatrixElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEColorMatrixElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEColorMatrixElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEColorMatrixElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEColorMatrixElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEColorMatrixElementEvents type, HtmlEventHandlerWithTarget<SVGFEColorMatrixElement> listener);

		public extern void RemoveEventListener(SVGFEColorMatrixElementEvents type, HtmlEventHandlerWithTarget<SVGFEColorMatrixElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEColorMatrixElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEColorMatrixElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		[Name("SVG_FECOLORMATRIX_TYPE_HUEROTATE")]
		public const ushort SVG_FECOLORMATRIX_TYPE_HUEROTATE = 3;

		[Name("SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA")]
		public const ushort SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA = 4;

		[Name("SVG_FECOLORMATRIX_TYPE_MATRIX")]
		public const ushort SVG_FECOLORMATRIX_TYPE_MATRIX = 1;

		[Name("SVG_FECOLORMATRIX_TYPE_SATURATE")]
		public const ushort SVG_FECOLORMATRIX_TYPE_SATURATE = 2;

		[Name("SVG_FECOLORMATRIX_TYPE_UNKNOWN")]
		public const ushort SVG_FECOLORMATRIX_TYPE_UNKNOWN = 0;

		public readonly SVGAnimatedEnumeration<SVGFEColorMatrixType> Type;

		public readonly SVGAnimatedNumberList Values;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
