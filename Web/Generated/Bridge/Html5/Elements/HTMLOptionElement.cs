namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLOptionElement : HTMLElement
	{
		[Template("new Option()")]
		public extern HTMLOptionElement();

		[Template("new Option({text})")]
		public extern HTMLOptionElement(string text);

		[Template("new Option({text}, {value})")]
		public extern HTMLOptionElement(string text, string value);

		[Template("new Option({text}, {value}, {defaultSelected})")]
		public extern HTMLOptionElement(string text, string value, bool defaultSelected);

		[Template("new Option({text}, {value}, {defaultSelected}, {selected})")]
		public extern HTMLOptionElement(string text, string value, bool defaultSelected, bool selected);

		public extern void AddEventListener(HTMLOptionElementEvents type, Action listener);

		public extern void AddEventListener(HTMLOptionElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLOptionElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLOptionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLOptionElementEvents type, HtmlEventHandlerWithTarget<HTMLOptionElement> listener);

		public extern void AddEventListener(HTMLOptionElementEvents type, HtmlEventHandlerWithTarget<HTMLOptionElement> listener, bool capture);

		public extern void AddEventListener(HTMLOptionElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLOptionElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLOptionElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLOptionElement> listener, bool capture);

		public bool DefaultSelected;

		public bool Disabled;

		public readonly HTMLFormElement Form;

		public readonly int Index;

		public string Label;

		public extern void RemoveEventListener(HTMLOptionElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLOptionElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLOptionElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLOptionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLOptionElementEvents type, HtmlEventHandlerWithTarget<HTMLOptionElement> listener);

		public extern void RemoveEventListener(HTMLOptionElementEvents type, HtmlEventHandlerWithTarget<HTMLOptionElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLOptionElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLOptionElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLOptionElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLOptionElement> listener, bool capture);

		public bool Selected;

		public string Text;

		public string Value;
	}
}
