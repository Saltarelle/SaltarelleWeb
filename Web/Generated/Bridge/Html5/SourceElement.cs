namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'SOURCE'"), Name("Element")]
	public partial class SourceElement : Element
	{
		internal extern SourceElement();

		public extern void AddEventListener(SourceElementEvents type, Action listener);

		public extern void AddEventListener(SourceElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SourceElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SourceElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SourceElementEvents type, HtmlEventHandlerWithTarget<SourceElement> listener);

		public extern void AddEventListener(SourceElementEvents type, HtmlEventHandlerWithTarget<SourceElement> listener, bool capture);

		public extern void AddEventListener(SourceElementEvents type, IEventListener listener);

		public extern void AddEventListener(SourceElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceElement> listener, bool capture);

		public string Media;

		public extern void RemoveEventListener(SourceElementEvents type, Action listener);

		public extern void RemoveEventListener(SourceElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SourceElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SourceElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SourceElementEvents type, HtmlEventHandlerWithTarget<SourceElement> listener);

		public extern void RemoveEventListener(SourceElementEvents type, HtmlEventHandlerWithTarget<SourceElement> listener, bool capture);

		public extern void RemoveEventListener(SourceElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SourceElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceElement> listener, bool capture);

		public string Src;

		public string Type;
	}
}
