using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FORM'"), Name("Element")]
	public partial class FormElement : Element
	{
		internal FormElement()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public Element this[int index]
		{
			get {
				return default(Element);
			}
		}

		[IndexerName("__Item"), FieldProperty]
		public Element this[string name]
		{
			get {
				return default(Element);
			}
		}

		[FieldProperty]
		public string AcceptCharset
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Action
		{
			get {
				return null;
			}
			set {
			}
		}

		public void AddEventListener(FormElementEvents type, Action listener)
		{
		}

		public void AddEventListener(FormElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(FormElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(FormElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener)
		{
		}

		public void AddEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture)
		{
		}

		public void AddEventListener(FormElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(FormElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture)
		{
		}

		[FieldProperty]
		public string Autocomplete
		{
			get {
				return null;
			}
			set {
			}
		}

		public bool CheckValidity()
		{
			return false;
		}

		[FieldProperty]
		public ElementCollection Elements
		{
			get {
				return default(ElementCollection);
			}
		}

		[FieldProperty]
		public string Encoding
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Enctype
		{
			get {
				return null;
			}
			set {
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<Element> GetEnumerator()
		{
			return null;
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string Method
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

		[FieldProperty]
		public bool NoValidate
		{
			get {
				return false;
			}
			set {
			}
		}

		public void RemoveEventListener(FormElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(FormElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(FormElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(FormElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener)
		{
		}

		public void RemoveEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(FormElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(FormElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture)
		{
		}

		public void Reset()
		{
		}

		public void Submit()
		{
		}

		[FieldProperty]
		public string Target
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
