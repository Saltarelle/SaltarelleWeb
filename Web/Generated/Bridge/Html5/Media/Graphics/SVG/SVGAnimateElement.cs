namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGAnimateElement : SVGAnimationElement
	{
		internal extern SVGAnimateElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimateElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimateElement> listener, bool capture);

		public extern void AddEventListener(SVGAnimateElementEvents type, Action listener);

		public extern void AddEventListener(SVGAnimateElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGAnimateElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGAnimateElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGAnimateElementEvents type, HtmlEventHandlerWithTarget<SVGAnimateElement> listener);

		public extern void AddEventListener(SVGAnimateElementEvents type, HtmlEventHandlerWithTarget<SVGAnimateElement> listener, bool capture);

		public extern void AddEventListener(SVGAnimateElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGAnimateElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimateElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimateElement> listener, bool capture);

		public extern void RemoveEventListener(SVGAnimateElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGAnimateElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGAnimateElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGAnimateElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGAnimateElementEvents type, HtmlEventHandlerWithTarget<SVGAnimateElement> listener);

		public extern void RemoveEventListener(SVGAnimateElementEvents type, HtmlEventHandlerWithTarget<SVGAnimateElement> listener, bool capture);

		public extern void RemoveEventListener(SVGAnimateElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGAnimateElementEvents type, IEventListener listener, bool capture);
	}
}
