namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGTextPositioningElement : SVGTextContentElement
	{
		internal extern SVGTextPositioningElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextPositioningElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextPositioningElement> listener, bool capture);

		public extern void AddEventListener(SVGTextPositioningElementEvents type, Action listener);

		public extern void AddEventListener(SVGTextPositioningElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGTextPositioningElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGTextPositioningElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGTextPositioningElementEvents type, HtmlEventHandlerWithTarget<SVGTextPositioningElement> listener);

		public extern void AddEventListener(SVGTextPositioningElementEvents type, HtmlEventHandlerWithTarget<SVGTextPositioningElement> listener, bool capture);

		public extern void AddEventListener(SVGTextPositioningElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGTextPositioningElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedLengthList Dx
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLengthList Dy
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextPositioningElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextPositioningElement> listener, bool capture);

		public extern void RemoveEventListener(SVGTextPositioningElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGTextPositioningElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGTextPositioningElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGTextPositioningElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGTextPositioningElementEvents type, HtmlEventHandlerWithTarget<SVGTextPositioningElement> listener);

		public extern void RemoveEventListener(SVGTextPositioningElementEvents type, HtmlEventHandlerWithTarget<SVGTextPositioningElement> listener, bool capture);

		public extern void RemoveEventListener(SVGTextPositioningElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGTextPositioningElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedNumberList Rotate
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLengthList X
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLengthList Y
		{
			get;
		}
	}
}
