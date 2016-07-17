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

		public readonly SVGAnimatedLengthList Dx;

		public readonly SVGAnimatedLengthList Dy;

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

		public readonly SVGAnimatedNumberList Rotate;

		public readonly SVGAnimatedLengthList X;

		public readonly SVGAnimatedLengthList Y;
	}
}
