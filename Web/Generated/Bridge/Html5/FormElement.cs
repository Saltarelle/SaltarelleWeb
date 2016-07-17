namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FORM'"), Name("Element")]
	public partial class FormElement : Element
	{
		internal extern FormElement();

		[IndexerName("__Item"), FieldProperty]
		public Element this[int index]
		{
			get;
		}

		[IndexerName("__Item"), FieldProperty]
		public Element this[string name]
		{
			get;
		}

		public string AcceptCharset;

		public string Action;

		public extern void AddEventListener(FormElementEvents type, Action listener);

		public extern void AddEventListener(FormElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(FormElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(FormElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener);

		public extern void AddEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture);

		public extern void AddEventListener(FormElementEvents type, IEventListener listener);

		public extern void AddEventListener(FormElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture);

		public string Autocomplete;

		public extern bool CheckValidity();

		public readonly ElementCollection Elements;

		public string Encoding;

		public string Enctype;

		public readonly int Length;

		public string Method;

		public string Name;

		public bool NoValidate;

		public extern void RemoveEventListener(FormElementEvents type, Action listener);

		public extern void RemoveEventListener(FormElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(FormElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(FormElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener);

		public extern void RemoveEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture);

		public extern void RemoveEventListener(FormElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(FormElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture);

		public extern void Reset();

		public extern void Submit();

		public string Target;
	}
}
