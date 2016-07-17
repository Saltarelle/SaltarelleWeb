namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGTextPathElement : SVGTextContentElement
	{
		internal extern SVGTextPathElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextPathElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextPathElement> listener, bool capture);

		public extern void AddEventListener(SVGTextPathElementEvents type, Action listener);

		public extern void AddEventListener(SVGTextPathElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGTextPathElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGTextPathElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGTextPathElementEvents type, HtmlEventHandlerWithTarget<SVGTextPathElement> listener);

		public extern void AddEventListener(SVGTextPathElementEvents type, HtmlEventHandlerWithTarget<SVGTextPathElement> listener, bool capture);

		public extern void AddEventListener(SVGTextPathElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGTextPathElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Href;

		public readonly SVGAnimatedEnumeration<SVGTextPathMethod> Method;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextPathElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextPathElement> listener, bool capture);

		public extern void RemoveEventListener(SVGTextPathElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGTextPathElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGTextPathElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGTextPathElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGTextPathElementEvents type, HtmlEventHandlerWithTarget<SVGTextPathElement> listener);

		public extern void RemoveEventListener(SVGTextPathElementEvents type, HtmlEventHandlerWithTarget<SVGTextPathElement> listener, bool capture);

		public extern void RemoveEventListener(SVGTextPathElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGTextPathElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedEnumeration<SVGTextPathSpacing> Spacing;

		public readonly SVGAnimatedLength StartOffset;

		[Name("TEXTPATH_METHODTYPE_ALIGN")]
		public const ushort TEXTPATH_METHODTYPE_ALIGN = 1;

		[Name("TEXTPATH_METHODTYPE_STRETCH")]
		public const ushort TEXTPATH_METHODTYPE_STRETCH = 2;

		[Name("TEXTPATH_METHODTYPE_UNKNOWN")]
		public const ushort TEXTPATH_METHODTYPE_UNKNOWN = 0;

		[Name("TEXTPATH_SPACINGTYPE_AUTO")]
		public const ushort TEXTPATH_SPACINGTYPE_AUTO = 1;

		[Name("TEXTPATH_SPACINGTYPE_EXACT")]
		public const ushort TEXTPATH_SPACINGTYPE_EXACT = 2;

		[Name("TEXTPATH_SPACINGTYPE_UNKNOWN")]
		public const ushort TEXTPATH_SPACINGTYPE_UNKNOWN = 0;
	}
}
