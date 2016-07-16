namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGTextContentElement : SVGGraphicsElement
	{
		internal extern SVGTextContentElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener, bool capture);

		public extern void AddEventListener(SVGTextContentElementEvents type, Action listener);

		public extern void AddEventListener(SVGTextContentElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGTextContentElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGTextContentElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGTextContentElementEvents type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener);

		public extern void AddEventListener(SVGTextContentElementEvents type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener, bool capture);

		public extern void AddEventListener(SVGTextContentElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGTextContentElementEvents type, IEventListener listener, bool capture);

		public extern int GetCharNumAtPosition(SVGPoint point);

		public extern double GetComputedTextLength();

		public extern SVGPoint GetEndPositionOfChar(int charnum);

		public extern SVGRect GetExtentOfChar(int charnum);

		public extern int GetNumberOfChars();

		public extern double GetRotationOfChar(int charnum);

		public extern SVGPoint GetStartPositionOfChar(int charnum);

		public extern double GetSubStringLength(int charnum, int nchars);

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGLengthAdjust> LengthAdjust
		{
			get;
		}

		[Name("LENGTHADJUST_SPACING")]
		public const ushort LENGTHADJUST_SPACING = 1;

		[Name("LENGTHADJUST_SPACINGANDGLYPHS")]
		public const ushort LENGTHADJUST_SPACINGANDGLYPHS = 2;

		[Name("LENGTHADJUST_UNKNOWN")]
		public const ushort LENGTHADJUST_UNKNOWN = 0;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener, bool capture);

		public extern void RemoveEventListener(SVGTextContentElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGTextContentElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGTextContentElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGTextContentElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGTextContentElementEvents type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener);

		public extern void RemoveEventListener(SVGTextContentElementEvents type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener, bool capture);

		public extern void RemoveEventListener(SVGTextContentElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGTextContentElementEvents type, IEventListener listener, bool capture);

		public extern void SelectSubString(int charnum, int nchars);

		[FieldProperty]
		public extern SVGAnimatedLength TextLength
		{
			get;
		}
	}
}
