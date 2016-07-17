namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class FieldSetElement : Element
	{
		internal extern FieldSetElement();

		public extern void AddEventListener(FieldSetElementEvents type, Action listener);

		public extern void AddEventListener(FieldSetElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(FieldSetElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(FieldSetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener);

		public extern void AddEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture);

		public extern void AddEventListener(FieldSetElementEvents type, IEventListener listener);

		public extern void AddEventListener(FieldSetElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture);

		public extern bool CheckValidity();

		public bool Disabled;

		public readonly ElementCollection Elements;

		public readonly FormElement Form;

		public string Name;

		public extern void RemoveEventListener(FieldSetElementEvents type, Action listener);

		public extern void RemoveEventListener(FieldSetElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener);

		public extern void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture);

		public extern void RemoveEventListener(FieldSetElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(FieldSetElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture);

		public extern void SetCustomValidity(string error);

		public readonly string Type;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public readonly bool WillValidate;
	}
}
