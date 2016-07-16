namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FIELDSET'"), Name("Element")]
	public partial class FieldSetElement : Element
	{
		internal FieldSetElement()
		{
		}

		public void AddEventListener(FieldSetElementEvents type, Action listener)
		{
		}

		public void AddEventListener(FieldSetElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(FieldSetElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(FieldSetElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener)
		{
		}

		public void AddEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture)
		{
		}

		public void AddEventListener(FieldSetElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(FieldSetElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture)
		{
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
		public ElementCollection Elements
		{
			get {
				return default(ElementCollection);
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
		public string Name
		{
			get {
				return null;
			}
			set {
			}
		}

		public void RemoveEventListener(FieldSetElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(FieldSetElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener)
		{
		}

		public void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(FieldSetElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(FieldSetElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture)
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
		public bool WillValidate
		{
			get {
				return false;
			}
		}
	}
}
