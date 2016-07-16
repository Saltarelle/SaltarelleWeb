namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGGradientElement : SVGElement
	{
		internal extern SVGGradientElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGGradientElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGGradientElement> listener, bool capture);

		public extern void AddEventListener(SVGGradientElementEvents type, Action listener);

		public extern void AddEventListener(SVGGradientElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGGradientElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGGradientElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGGradientElementEvents type, HtmlEventHandlerWithTarget<SVGGradientElement> listener);

		public extern void AddEventListener(SVGGradientElementEvents type, HtmlEventHandlerWithTarget<SVGGradientElement> listener, bool capture);

		public extern void AddEventListener(SVGGradientElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGGradientElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedTransformList GradientTransform
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGUnitType> GradientUnits
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedString Href
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGGradientElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGGradientElement> listener, bool capture);

		public extern void RemoveEventListener(SVGGradientElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGGradientElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGGradientElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGGradientElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGGradientElementEvents type, HtmlEventHandlerWithTarget<SVGGradientElement> listener);

		public extern void RemoveEventListener(SVGGradientElementEvents type, HtmlEventHandlerWithTarget<SVGGradientElement> listener, bool capture);

		public extern void RemoveEventListener(SVGGradientElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGGradientElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGSpreadMethod> SpreadMethod
		{
			get;
		}

		[Name("SVG_SPREADMETHOD_PAD")]
		public const ushort SVG_SPREADMETHOD_PAD = 1;

		[Name("SVG_SPREADMETHOD_REFLECT")]
		public const ushort SVG_SPREADMETHOD_REFLECT = 2;

		[Name("SVG_SPREADMETHOD_REPEAT")]
		public const ushort SVG_SPREADMETHOD_REPEAT = 3;

		[Name("SVG_SPREADMETHOD_UNKNOWN")]
		public const ushort SVG_SPREADMETHOD_UNKNOWN = 0;

		[Name("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
		public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;

		[Name("SVG_UNIT_TYPE_UNKNOWN")]
		public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

		[Name("SVG_UNIT_TYPE_USERSPACEONUSE")]
		public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;
	}
}
