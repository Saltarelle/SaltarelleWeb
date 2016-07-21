namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLLabelElement : HTMLElement
	{
		internal extern HTMLLabelElement();

		public extern void AddEventListener(HTMLLabelElementEvents type, Action listener);

		public extern void AddEventListener(HTMLLabelElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLLabelElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLLabelElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLLabelElementEvents type, HtmlEventHandlerWithTarget<HTMLLabelElement> listener);

		public extern void AddEventListener(HTMLLabelElementEvents type, HtmlEventHandlerWithTarget<HTMLLabelElement> listener, bool capture);

		public extern void AddEventListener(HTMLLabelElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLLabelElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLLabelElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLLabelElement> listener, bool capture);

		public readonly HTMLElement Control;

		public readonly HTMLFormElement Form;

		public string HtmlFor;

		public extern void RemoveEventListener(HTMLLabelElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLLabelElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLLabelElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLLabelElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLLabelElementEvents type, HtmlEventHandlerWithTarget<HTMLLabelElement> listener);

		public extern void RemoveEventListener(HTMLLabelElementEvents type, HtmlEventHandlerWithTarget<HTMLLabelElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLLabelElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLLabelElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLLabelElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLLabelElement> listener, bool capture);
	}
}
