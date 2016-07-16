namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FIELDSET'"), Name("Element")]
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

		[FieldProperty]
		public extern bool Disabled
		{
			get;
			set;
		}

		[FieldProperty]
		public extern ElementCollection Elements
		{
			get;
		}

		[FieldProperty]
		public extern FormElement Form
		{
			get;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern string Type
		{
			get;
		}

		[FieldProperty]
		public extern string ValidationMessage
		{
			get;
		}

		[FieldProperty]
		public extern ValidityState Validity
		{
			get;
		}

		[FieldProperty]
		public extern bool WillValidate
		{
			get;
		}
	}
}
