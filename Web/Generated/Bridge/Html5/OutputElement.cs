namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OUTPUT'"), Name("Element")]
	public partial class OutputElement : Element
	{
		internal OutputElement()
		{
		}

		public void AddEventListener(OutputElementEvents type, Action listener)
		{
		}

		public void AddEventListener(OutputElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(OutputElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(OutputElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener)
		{
		}

		public void AddEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture)
		{
		}

		public void AddEventListener(OutputElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(OutputElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture)
		{
		}

		public bool CheckValidity()
		{
			return false;
		}

		[FieldProperty]
		public string DefaultValue
		{
			get {
				return null;
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
		public DOMSettableTokenList HtmlFor
		{
			get {
				return default(DOMSettableTokenList);
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

		public void RemoveEventListener(OutputElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(OutputElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(OutputElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(OutputElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener)
		{
		}

		public void RemoveEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(OutputElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(OutputElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture)
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
