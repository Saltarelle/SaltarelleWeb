namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGTSpanElement : SVGTextPositioningElement
	{
		internal extern SVGTSpanElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTSpanElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTSpanElement> listener, bool capture);

		public extern void AddEventListener(SVGTSpanElementEvents type, Action listener);

		public extern void AddEventListener(SVGTSpanElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGTSpanElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGTSpanElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGTSpanElementEvents type, HtmlEventHandlerWithTarget<SVGTSpanElement> listener);

		public extern void AddEventListener(SVGTSpanElementEvents type, HtmlEventHandlerWithTarget<SVGTSpanElement> listener, bool capture);

		public extern void AddEventListener(SVGTSpanElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGTSpanElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTSpanElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTSpanElement> listener, bool capture);

		public extern void RemoveEventListener(SVGTSpanElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGTSpanElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGTSpanElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGTSpanElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGTSpanElementEvents type, HtmlEventHandlerWithTarget<SVGTSpanElement> listener);

		public extern void RemoveEventListener(SVGTSpanElementEvents type, HtmlEventHandlerWithTarget<SVGTSpanElement> listener, bool capture);

		public extern void RemoveEventListener(SVGTSpanElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGTSpanElementEvents type, IEventListener listener, bool capture);
	}
}
