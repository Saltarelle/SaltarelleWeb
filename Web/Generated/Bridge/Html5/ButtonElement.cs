namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'BUTTON'"), Name("Element")]
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

		[FieldProperty]
		public extern bool Autofocus
		{
			get;
			set;
		}

		public extern bool CheckValidity();

		[FieldProperty]
		public extern bool Disabled
		{
			get;
			set;
		}

		[FieldProperty]
		public extern FormElement Form
		{
			get;
		}

		[FieldProperty]
		public extern string FormAction
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string FormEnctype
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string FormMethod
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool FormNoValidate
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string FormTarget
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern string Type
		{
			get;
			set;
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
		public extern string Value
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool WillValidate
		{
			get;
		}
	}
}
