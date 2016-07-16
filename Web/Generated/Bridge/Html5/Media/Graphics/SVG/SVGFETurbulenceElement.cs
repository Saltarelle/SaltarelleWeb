namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern SVGAnimatedNumber BaseFrequencyX
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber BaseFrequencyY
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Height
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedInteger NumOctaves
		{
			get;
		}

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

		[FieldProperty]
		public extern SVGAnimatedString Result
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Seed
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGFEStitchType> StitchTiles
		{
			get;
		}

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

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGFETurbulenceType> Type
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
