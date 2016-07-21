namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLOutputElement : HTMLElement
	{
		internal extern HTMLOutputElement();

		public extern void AddEventListener(HTMLOutputElementEvents type, Action listener);

		public extern void AddEventListener(HTMLOutputElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLOutputElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLOutputElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLOutputElementEvents type, HtmlEventHandlerWithTarget<HTMLOutputElement> listener);

		public extern void AddEventListener(HTMLOutputElementEvents type, HtmlEventHandlerWithTarget<HTMLOutputElement> listener, bool capture);

		public extern void AddEventListener(HTMLOutputElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLOutputElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLOutputElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLOutputElement> listener, bool capture);

		public extern bool CheckValidity();

		public string DefaultValue;

		public readonly HTMLFormElement Form;

		public readonly DOMSettableTokenList HtmlFor;

		public string Name;

		public extern void RemoveEventListener(HTMLOutputElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLOutputElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLOutputElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLOutputElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLOutputElementEvents type, HtmlEventHandlerWithTarget<HTMLOutputElement> listener);

		public extern void RemoveEventListener(HTMLOutputElementEvents type, HtmlEventHandlerWithTarget<HTMLOutputElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLOutputElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLOutputElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLOutputElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLOutputElement> listener, bool capture);

		public extern void SetCustomValidity(string error);

		public readonly string Type;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public string Value;

		public readonly bool WillValidate;
	}
}
