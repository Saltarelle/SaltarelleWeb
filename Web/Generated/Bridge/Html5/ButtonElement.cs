namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class ButtonElement : Element
	{
		internal extern ButtonElement();

		public extern void AddEventListener(ButtonElementEvents type, Action listener);

		public extern void AddEventListener(ButtonElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ButtonElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ButtonElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ButtonElementEvents type, HtmlEventHandlerWithTarget<ButtonElement> listener);

		public extern void AddEventListener(ButtonElementEvents type, HtmlEventHandlerWithTarget<ButtonElement> listener, bool capture);

		public extern void AddEventListener(ButtonElementEvents type, IEventListener listener);

		public extern void AddEventListener(ButtonElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ButtonElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ButtonElement> listener, bool capture);

		public bool Autofocus;

		public extern bool CheckValidity();

		public bool Disabled;

		public readonly FormElement Form;

		public string FormAction;

		public string FormEnctype;

		public string FormMethod;

		public bool FormNoValidate;

		public string FormTarget;

		public string Name;

		public extern void RemoveEventListener(ButtonElementEvents type, Action listener);

		public extern void RemoveEventListener(ButtonElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ButtonElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ButtonElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ButtonElementEvents type, HtmlEventHandlerWithTarget<ButtonElement> listener);

		public extern void RemoveEventListener(ButtonElementEvents type, HtmlEventHandlerWithTarget<ButtonElement> listener, bool capture);

		public extern void RemoveEventListener(ButtonElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ButtonElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ButtonElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ButtonElement> listener, bool capture);

		public extern void SetCustomValidity(string error);

		public string Type;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public string Value;

		public readonly bool WillValidate;
	}
}
