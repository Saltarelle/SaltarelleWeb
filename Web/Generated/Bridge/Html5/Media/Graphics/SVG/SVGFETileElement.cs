namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFETileElement : SVGElement
	{
		internal extern SVGFETileElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFETileElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFETileElement> listener, bool capture);

		public extern void AddEventListener(SVGFETileElementEvents type, Action listener);

		public extern void AddEventListener(SVGFETileElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFETileElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFETileElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFETileElementEvents type, HtmlEventHandlerWithTarget<SVGFETileElement> listener);

		public extern void AddEventListener(SVGFETileElementEvents type, HtmlEventHandlerWithTarget<SVGFETileElement> listener, bool capture);

		public extern void AddEventListener(SVGFETileElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFETileElementEvents type, IEventListener listener, bool capture);

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

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFETileElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFETileElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFETileElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFETileElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFETileElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFETileElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFETileElementEvents type, HtmlEventHandlerWithTarget<SVGFETileElement> listener);

		public extern void RemoveEventListener(SVGFETileElementEvents type, HtmlEventHandlerWithTarget<SVGFETileElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFETileElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFETileElementEvents type, IEventListener listener, bool capture);

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
