namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGScriptElement : SVGElement
	{
		internal extern SVGScriptElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGScriptElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGScriptElement> listener, bool capture);

		public extern void AddEventListener(SVGScriptElementEvents type, Action listener);

		public extern void AddEventListener(SVGScriptElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGScriptElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGScriptElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGScriptElementEvents type, HtmlEventHandlerWithTarget<SVGScriptElement> listener);

		public extern void AddEventListener(SVGScriptElementEvents type, HtmlEventHandlerWithTarget<SVGScriptElement> listener, bool capture);

		public extern void AddEventListener(SVGScriptElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGScriptElementEvents type, IEventListener listener, bool capture);

		public string CrossOrigin;

		public readonly SVGAnimatedString Href;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGScriptElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGScriptElement> listener, bool capture);

		public extern void RemoveEventListener(SVGScriptElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGScriptElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGScriptElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGScriptElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGScriptElementEvents type, HtmlEventHandlerWithTarget<SVGScriptElement> listener);

		public extern void RemoveEventListener(SVGScriptElementEvents type, HtmlEventHandlerWithTarget<SVGScriptElement> listener, bool capture);

		public extern void RemoveEventListener(SVGScriptElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGScriptElementEvents type, IEventListener listener, bool capture);

		public string Type;
	}
}
