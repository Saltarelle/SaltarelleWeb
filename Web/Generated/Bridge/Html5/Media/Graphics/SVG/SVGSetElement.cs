namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGSetElement : SVGAnimationElement
	{
		internal extern SVGSetElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGSetElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGSetElement> listener, bool capture);

		public extern void AddEventListener(SVGSetElementEvents type, Action listener);

		public extern void AddEventListener(SVGSetElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGSetElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGSetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGSetElementEvents type, HtmlEventHandlerWithTarget<SVGSetElement> listener);

		public extern void AddEventListener(SVGSetElementEvents type, HtmlEventHandlerWithTarget<SVGSetElement> listener, bool capture);

		public extern void AddEventListener(SVGSetElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGSetElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGSetElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGSetElement> listener, bool capture);

		public extern void RemoveEventListener(SVGSetElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGSetElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGSetElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGSetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGSetElementEvents type, HtmlEventHandlerWithTarget<SVGSetElement> listener);

		public extern void RemoveEventListener(SVGSetElementEvents type, HtmlEventHandlerWithTarget<SVGSetElement> listener, bool capture);

		public extern void RemoveEventListener(SVGSetElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGSetElementEvents type, IEventListener listener, bool capture);
	}
}
