namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'BUTTON'"), Name("Element")]
	public partial class ButtonElement : Element
	{
		internal ButtonElement()
		{
		}

		public void AddEventListener(ButtonElementEvents type, Action listener)
		{
		}

		public void AddEventListener(ButtonElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(ButtonElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(ButtonElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(ButtonElementEvents type, HtmlEventHandlerWithTarget<ButtonElement> listener)
		{
		}

		public void AddEventListener(ButtonElementEvents type, HtmlEventHandlerWithTarget<ButtonElement> listener, bool capture)
		{
		}

		public void AddEventListener(ButtonElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(ButtonElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ButtonElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ButtonElement> listener, bool capture)
		{
		}

		[FieldProperty]
		public bool Autofocus
		{
			get {
				return false;
			}
			set {
			}
		}

		public bool CheckValidity()
		{
			return false;
		}

		[FieldProperty]
		public bool Disabled
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public FormElement Form
		{
			get {
				return default(FormElement);
			}
		}

		[FieldProperty]
		public string FormAction
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string FormEnctype
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string FormMethod
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool FormNoValidate
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public string FormTarget
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Name
		{
			get {
				return null;
			}
			set {
			}
		}

		public void RemoveEventListener(ButtonElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(ButtonElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(ButtonElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(ButtonElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(ButtonElementEvents type, HtmlEventHandlerWithTarget<ButtonElement> listener)
		{
		}

		public void RemoveEventListener(ButtonElementEvents type, HtmlEventHandlerWithTarget<ButtonElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(ButtonElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(ButtonElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ButtonElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ButtonElement> listener, bool capture)
		{
		}

		public void SetCustomValidity(string error)
		{
		}

		[FieldProperty]
		public string Type
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string ValidationMessage
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public ValidityState Validity
		{
			get {
				return default(ValidityState);
			}
		}

		[FieldProperty]
		public string Value
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool WillValidate
		{
			get {
				return false;
			}
		}
	}
}
