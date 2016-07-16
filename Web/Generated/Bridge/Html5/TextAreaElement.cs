namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TEXTAREA'"), Name("Element")]
	public partial class TextAreaElement : Element
	{
		internal TextAreaElement()
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextAreaElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextAreaElement> listener, bool capture)
		{
		}

		public void AddEventListener(TextAreaElementEvents type, Action listener)
		{
		}

		public void AddEventListener(TextAreaElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(TextAreaElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(TextAreaElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(TextAreaElementEvents type, HtmlEventHandlerWithTarget<TextAreaElement> listener)
		{
		}

		public void AddEventListener(TextAreaElementEvents type, HtmlEventHandlerWithTarget<TextAreaElement> listener, bool capture)
		{
		}

		public void AddEventListener(TextAreaElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(TextAreaElementEvents type, IEventListener listener, bool capture)
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
		public int Cols
		{
			get {
				return 0;
			}
			set {
			}
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
		public int MaxLength
		{
			get {
				return 0;
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

		[FieldProperty]
		public string Placeholder
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool ReadOnly
		{
			get {
				return false;
			}
			set {
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextAreaElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextAreaElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(TextAreaElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(TextAreaElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(TextAreaElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(TextAreaElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(TextAreaElementEvents type, HtmlEventHandlerWithTarget<TextAreaElement> listener)
		{
		}

		public void RemoveEventListener(TextAreaElementEvents type, HtmlEventHandlerWithTarget<TextAreaElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(TextAreaElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(TextAreaElementEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public bool Required
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public int Rows
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void Select()
		{
		}

		[FieldProperty]
		public string SelectionDirection
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public int SelectionEnd
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int SelectionStart
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void SetCustomValidity(string error)
		{
		}

		public void SetRangeText(string replacement)
		{
		}

		public void SetRangeText(string replacement, int start, int end)
		{
		}

		public void SetRangeText(string replacement, int start, int end, SelectionMode selectionMode)
		{
		}

		public void SetSelectionRange(int start, int end)
		{
		}

		public void SetSelectionRange(int start, int end, string direction)
		{
		}

		[FieldProperty]
		public int TextLength
		{
			get {
				return 0;
			}
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

		[FieldProperty]
		public string Wrap
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
