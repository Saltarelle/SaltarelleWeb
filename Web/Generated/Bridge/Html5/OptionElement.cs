namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OPTION'"), Name("Element")]
	public partial class OptionElement : Element
	{
		[Template("new Option()")]
		public OptionElement()
		{
		}

		[Template("new Option({text})")]
		public OptionElement(string text)
		{
		}

		[Template("new Option({text}, {value})")]
		public OptionElement(string text, string value)
		{
		}

		[Template("new Option({text}, {value}, {defaultSelected})")]
		public OptionElement(string text, string value, bool defaultSelected)
		{
		}

		[Template("new Option({text}, {value}, {defaultSelected}, {selected})")]
		public OptionElement(string text, string value, bool defaultSelected, bool selected)
		{
		}

		public void AddEventListener(OptionElementEvents type, Action listener)
		{
		}

		public void AddEventListener(OptionElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(OptionElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(OptionElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener)
		{
		}

		public void AddEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture)
		{
		}

		public void AddEventListener(OptionElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(OptionElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture)
		{
		}

		[FieldProperty]
		public bool DefaultSelected
		{
			get {
				return false;
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
		public int Index
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string Label
		{
			get {
				return null;
			}
			set {
			}
		}

		public void RemoveEventListener(OptionElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(OptionElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(OptionElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(OptionElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener)
		{
		}

		public void RemoveEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(OptionElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(OptionElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture)
		{
		}

		[FieldProperty]
		public bool Selected
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public string Text
		{
			get {
				return null;
			}
			set {
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
	}
}
