using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OBJECT'"), Name("Element")]
	public partial class ObjectElement : Element
	{
		internal ObjectElement()
		{
		}

		public void AddEventListener(ObjectElementEvents type, Action listener)
		{
		}

		public void AddEventListener(ObjectElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(ObjectElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(ObjectElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener)
		{
		}

		public void AddEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture)
		{
		}

		public void AddEventListener(ObjectElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(ObjectElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture)
		{
		}

		[FieldProperty]
		public string Align
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Archive
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Border
		{
			get {
				return null;
			}
			set {
			}
		}

		[Template("{this}({*arguments})")]
		public object Call(params object[] arguments)
		{
			return null;
		}

		public bool CheckValidity()
		{
			return false;
		}

		[FieldProperty]
		public string Code
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string CodeBase
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string CodeType
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public DocumentBase ContentDocument
		{
			get {
				return default(DocumentBase);
			}
		}

		[FieldProperty]
		public WindowInstance ContentWindow
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public string Data
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Declare
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

		public DocumentBase GetSVGDocument()
		{
			return default(DocumentBase);
		}

		[FieldProperty]
		public string Height
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public int Hspace
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

		public void RemoveEventListener(ObjectElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(ObjectElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(ObjectElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(ObjectElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener)
		{
		}

		public void RemoveEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(ObjectElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(ObjectElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture)
		{
		}

		public void SetCustomValidity(string error)
		{
		}

		[FieldProperty]
		public string Standby
		{
			get {
				return null;
			}
			set {
			}
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
		public bool TypeMustMatch
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public string UseMap
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
		public int Vspace
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public string Width
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
