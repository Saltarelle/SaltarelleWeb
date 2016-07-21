namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLButtonElement : HTMLElement
	{
		internal extern HTMLButtonElement();

		public extern void AddEventListener(HTMLButtonElementEvents type, Action listener);

		public extern void AddEventListener(HTMLButtonElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLButtonElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLButtonElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLButtonElementEvents type, HtmlEventHandlerWithTarget<HTMLButtonElement> listener);

		public extern void AddEventListener(HTMLButtonElementEvents type, HtmlEventHandlerWithTarget<HTMLButtonElement> listener, bool capture);

		public extern void AddEventListener(HTMLButtonElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLButtonElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLButtonElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLButtonElement> listener, bool capture);

		public bool Autofocus;

		public extern bool CheckValidity();

		public bool Disabled;

		public readonly HTMLFormElement Form;

		public string FormAction;

		public string FormEnctype;

		public string FormMethod;

		public bool FormNoValidate;

		public string FormTarget;

		public string Name;

		public extern void RemoveEventListener(HTMLButtonElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLButtonElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLButtonElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLButtonElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLButtonElementEvents type, HtmlEventHandlerWithTarget<HTMLButtonElement> listener);

		public extern void RemoveEventListener(HTMLButtonElementEvents type, HtmlEventHandlerWithTarget<HTMLButtonElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLButtonElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLButtonElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLButtonElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLButtonElement> listener, bool capture);

		public extern void SetCustomValidity(string error);

		public string Type;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public string Value;

		public readonly bool WillValidate;
	}
}
