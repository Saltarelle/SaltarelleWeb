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

		[FieldProperty]
		public extern bool Async
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Charset
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string CrossOrigin
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Defer
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Event
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string HtmlFor
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern string Src
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Text
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
			set;
		}
	}
}
