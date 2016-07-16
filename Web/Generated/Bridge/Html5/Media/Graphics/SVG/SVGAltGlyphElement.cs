namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGAltGlyphElement : SVGTextPositioningElement
	{
		internal extern SVGAltGlyphElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAltGlyphElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAltGlyphElement> listener, bool capture);

		public extern void AddEventListener(SVGAltGlyphElementEvents type, Action listener);

		public extern void AddEventListener(SVGAltGlyphElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGAltGlyphElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGAltGlyphElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGAltGlyphElementEvents type, HtmlEventHandlerWithTarget<SVGAltGlyphElement> listener);

		public extern void AddEventListener(SVGAltGlyphElementEvents type, HtmlEventHandlerWithTarget<SVGAltGlyphElement> listener, bool capture);

		public extern void AddEventListener(SVGAltGlyphElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGAltGlyphElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern string Format
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string GlyphRef
		{
			get;
			set;
		}

		[FieldProperty]
		public extern SVGAnimatedString Href
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAltGlyphElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAltGlyphElement> listener, bool capture);

		public extern void RemoveEventListener(SVGAltGlyphElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGAltGlyphElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGAltGlyphElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGAltGlyphElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGAltGlyphElementEvents type, HtmlEventHandlerWithTarget<SVGAltGlyphElement> listener);

		public extern void RemoveEventListener(SVGAltGlyphElementEvents type, HtmlEventHandlerWithTarget<SVGAltGlyphElement> listener, bool capture);

		public extern void RemoveEventListener(SVGAltGlyphElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGAltGlyphElementEvents type, IEventListener listener, bool capture);
	}
}
