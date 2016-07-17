namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class OutputElement : Element
	{
		internal extern OutputElement();

		public extern void AddEventListener(OutputElementEvents type, Action listener);

		public extern void AddEventListener(OutputElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(OutputElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(OutputElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener);

		public extern void AddEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture);

		public extern void AddEventListener(OutputElementEvents type, IEventListener listener);

		public extern void AddEventListener(OutputElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture);

		public extern bool CheckValidity();

		public string DefaultValue;

		public readonly FormElement Form;

		public readonly DOMSettableTokenList HtmlFor;

		public string Name;

		public extern void RemoveEventListener(OutputElementEvents type, Action listener);

		public extern void RemoveEventListener(OutputElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(OutputElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(OutputElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener);

		public extern void RemoveEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture);

		public extern void RemoveEventListener(OutputElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(OutputElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture);

		public extern void SetCustomValidity(string error);

		public readonly string Type;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public string Value;

		public readonly bool WillValidate;
	}
}
