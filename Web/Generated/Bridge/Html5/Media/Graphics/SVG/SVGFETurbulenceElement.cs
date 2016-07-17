namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGFETurbulenceElement : SVGElement
	{
		internal extern SVGFETurbulenceElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener, bool capture);

		public extern void AddEventListener(SVGFETurbulenceElementEvents type, Action listener);

		public extern void AddEventListener(SVGFETurbulenceElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFETurbulenceElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFETurbulenceElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFETurbulenceElementEvents type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener);

		public extern void AddEventListener(SVGFETurbulenceElementEvents type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener, bool capture);

		public extern void AddEventListener(SVGFETurbulenceElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFETurbulenceElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedNumber BaseFrequencyX;

		public readonly SVGAnimatedNumber BaseFrequencyY;

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedInteger NumOctaves;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFETurbulenceElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFETurbulenceElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFETurbulenceElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFETurbulenceElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFETurbulenceElementEvents type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener);

		public extern void RemoveEventListener(SVGFETurbulenceElementEvents type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFETurbulenceElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFETurbulenceElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		public readonly SVGAnimatedNumber Seed;

		public readonly SVGAnimatedEnumeration<SVGFEStitchType> StitchTiles;

		[Name("SVG_STITCHTYPE_NOSTITCH")]
		public const ushort SVG_STITCHTYPE_NOSTITCH = 2;

		[Name("SVG_STITCHTYPE_STITCH")]
		public const ushort SVG_STITCHTYPE_STITCH = 1;

		[Name("SVG_STITCHTYPE_UNKNOWN")]
		public const ushort SVG_STITCHTYPE_UNKNOWN = 0;

		[Name("SVG_TURBULENCE_TYPE_FRACTALNOISE")]
		public const ushort SVG_TURBULENCE_TYPE_FRACTALNOISE = 1;

		[Name("SVG_TURBULENCE_TYPE_TURBULENCE")]
		public const ushort SVG_TURBULENCE_TYPE_TURBULENCE = 2;

		[Name("SVG_TURBULENCE_TYPE_UNKNOWN")]
		public const ushort SVG_TURBULENCE_TYPE_UNKNOWN = 0;

		public readonly SVGAnimatedEnumeration<SVGFETurbulenceType> Type;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
