namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'SCRIPT'"), Name("Element")]
	public partial class ScriptElement : Element
	{
		internal extern ScriptElement();

		public extern void AddEventListener(ScriptElementEvents type, Action listener);

		public extern void AddEventListener(ScriptElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ScriptElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ScriptElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ScriptElementEvents type, HtmlEventHandlerWithTarget<ScriptElement> listener);

		public extern void AddEventListener(ScriptElementEvents type, HtmlEventHandlerWithTarget<ScriptElement> listener, bool capture);

		public extern void AddEventListener(ScriptElementEvents type, IEventListener listener);

		public extern void AddEventListener(ScriptElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ScriptElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ScriptElement> listener, bool capture);

		public bool Async;

		public string Charset;

		public string CrossOrigin;

		public bool Defer;

		public string Event;

		public string HtmlFor;

		public extern void RemoveEventListener(ScriptElementEvents type, Action listener);

		public extern void RemoveEventListener(ScriptElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ScriptElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ScriptElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ScriptElementEvents type, HtmlEventHandlerWithTarget<ScriptElement> listener);

		public extern void RemoveEventListener(ScriptElementEvents type, HtmlEventHandlerWithTarget<ScriptElement> listener, bool capture);

		public extern void RemoveEventListener(ScriptElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ScriptElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ScriptElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ScriptElement> listener, bool capture);

		public string Src;

		public string Text;

		public string Type;
	}
}
