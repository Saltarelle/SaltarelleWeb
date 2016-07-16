namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFEComponentTransferElement : SVGElement
	{
		internal extern SVGFEComponentTransferElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener, bool capture);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener, bool capture);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEComponentTransferElementEvents type, IEventListener listener, bool capture);

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

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, HtmlEventHandlerWithTarget<SVGFEComponentTransferElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEComponentTransferElementEvents type, IEventListener listener, bool capture);

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
