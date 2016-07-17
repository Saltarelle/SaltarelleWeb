namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGGElement : SVGGraphicsElement
	{
		internal extern SVGGElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGGElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGGElement> listener, bool capture);

		public extern void AddEventListener(SVGGElementEvents type, Action listener);

		public extern void AddEventListener(SVGGElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGGElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGGElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGGElementEvents type, HtmlEventHandlerWithTarget<SVGGElement> listener);

		public extern void AddEventListener(SVGGElementEvents type, HtmlEventHandlerWithTarget<SVGGElement> listener, bool capture);

		public extern void AddEventListener(SVGGElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGGElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGGElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGGElement> listener, bool capture);

		public extern void RemoveEventListener(SVGGElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGGElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGGElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGGElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGGElementEvents type, HtmlEventHandlerWithTarget<SVGGElement> listener);

		public extern void RemoveEventListener(SVGGElementEvents type, HtmlEventHandlerWithTarget<SVGGElement> listener, bool capture);

		public extern void RemoveEventListener(SVGGElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGGElementEvents type, IEventListener listener, bool capture);
	}
}
