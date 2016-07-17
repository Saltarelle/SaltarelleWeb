namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGTextElement : SVGTextPositioningElement
	{
		internal extern SVGTextElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextElement> listener, bool capture);

		public extern void AddEventListener(SVGTextElementEvents type, Action listener);

		public extern void AddEventListener(SVGTextElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGTextElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGTextElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGTextElementEvents type, HtmlEventHandlerWithTarget<SVGTextElement> listener);

		public extern void AddEventListener(SVGTextElementEvents type, HtmlEventHandlerWithTarget<SVGTextElement> listener, bool capture);

		public extern void AddEventListener(SVGTextElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGTextElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextElement> listener, bool capture);

		public extern void RemoveEventListener(SVGTextElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGTextElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGTextElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGTextElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGTextElementEvents type, HtmlEventHandlerWithTarget<SVGTextElement> listener);

		public extern void RemoveEventListener(SVGTextElementEvents type, HtmlEventHandlerWithTarget<SVGTextElement> listener, bool capture);

		public extern void RemoveEventListener(SVGTextElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGTextElementEvents type, IEventListener listener, bool capture);
	}
}
