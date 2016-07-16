namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGForeignObjectElement : SVGGraphicsElement
	{
		internal extern SVGForeignObjectElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGForeignObjectElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGForeignObjectElement> listener, bool capture);

		public extern void AddEventListener(SVGForeignObjectElementEvents type, Action listener);

		public extern void AddEventListener(SVGForeignObjectElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGForeignObjectElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGForeignObjectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGForeignObjectElementEvents type, HtmlEventHandlerWithTarget<SVGForeignObjectElement> listener);

		public extern void AddEventListener(SVGForeignObjectElementEvents type, HtmlEventHandlerWithTarget<SVGForeignObjectElement> listener, bool capture);

		public extern void AddEventListener(SVGForeignObjectElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGForeignObjectElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedLength Height
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGForeignObjectElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGForeignObjectElement> listener, bool capture);

		public extern void RemoveEventListener(SVGForeignObjectElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGForeignObjectElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGForeignObjectElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGForeignObjectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGForeignObjectElementEvents type, HtmlEventHandlerWithTarget<SVGForeignObjectElement> listener);

		public extern void RemoveEventListener(SVGForeignObjectElementEvents type, HtmlEventHandlerWithTarget<SVGForeignObjectElement> listener, bool capture);

		public extern void RemoveEventListener(SVGForeignObjectElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGForeignObjectElementEvents type, IEventListener listener, bool capture);

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
