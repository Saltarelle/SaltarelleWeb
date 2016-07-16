namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFEOffsetElement : SVGElement
	{
		internal extern SVGFEOffsetElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener, bool capture);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener, bool capture);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEOffsetElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedNumber Dx
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Dy
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

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, HtmlEventHandlerWithTarget<SVGFEOffsetElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEOffsetElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedString Result
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
