namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGFEDisplacementMapElement : SVGElement
	{
		internal extern SVGFEDisplacementMapElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDisplacementMapElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDisplacementMapElement> listener, bool capture);

		public extern void AddEventListener(SVGFEDisplacementMapElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEDisplacementMapElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEDisplacementMapElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEDisplacementMapElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEDisplacementMapElementEvents type, HtmlEventHandlerWithTarget<SVGFEDisplacementMapElement> listener);

		public extern void AddEventListener(SVGFEDisplacementMapElementEvents type, HtmlEventHandlerWithTarget<SVGFEDisplacementMapElement> listener, bool capture);

		public extern void AddEventListener(SVGFEDisplacementMapElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEDisplacementMapElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public readonly SVGAnimatedString In2;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDisplacementMapElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEDisplacementMapElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEDisplacementMapElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEDisplacementMapElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEDisplacementMapElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEDisplacementMapElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEDisplacementMapElementEvents type, HtmlEventHandlerWithTarget<SVGFEDisplacementMapElement> listener);

		public extern void RemoveEventListener(SVGFEDisplacementMapElementEvents type, HtmlEventHandlerWithTarget<SVGFEDisplacementMapElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEDisplacementMapElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEDisplacementMapElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		public readonly SVGAnimatedNumber Scale;

		[Name("SVG_CHANNEL_A")]
		public const ushort SVG_CHANNEL_A = 4;

		[Name("SVG_CHANNEL_B")]
		public const ushort SVG_CHANNEL_B = 3;

		[Name("SVG_CHANNEL_G")]
		public const ushort SVG_CHANNEL_G = 2;

		[Name("SVG_CHANNEL_R")]
		public const ushort SVG_CHANNEL_R = 1;

		[Name("SVG_CHANNEL_UNKNOWN")]
		public const ushort SVG_CHANNEL_UNKNOWN = 0;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedEnumeration<SVGFEDisplacementMapChannelSelector> XChannelSelector;

		public readonly SVGAnimatedLength Y;

		public readonly SVGAnimatedEnumeration<SVGFEDisplacementMapChannelSelector> YChannelSelector;
	}
}
