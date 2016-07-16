using System;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'SELECT'"), Name("Element")]
	public partial class SelectElement : Element
	{
		internal SelectElement()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public TypeOption<Element, OptionElement> this[int index]
		{
			get {
				return default(TypeOption<Element, OptionElement>);
			}
			set {
			}
		}

		public void Add(TypeOption<OptionElement, OptGroupElement> element)
		{
		}

		public void Add(TypeOption<OptionElement, OptGroupElement> element, TypeOption<Element, int> before)
		{
		}

		public void AddEventListener(SelectElementEvents type, Action listener)
		{
		}

		public void AddEventListener(SelectElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(SelectElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(SelectElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener)
		{
		}

		public void AddEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture)
		{
		}

		public void AddEventListener(SelectElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(SelectElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture)
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

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<Element> GetEnumerator()
		{
			return null;
		}

		public Element Item(int index)
		{
			return default(Element);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Multiple
		{
			get {
				return false;
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

		public OptionElement NamedItem(string name)
		{
			return default(OptionElement);
		}

		[FieldProperty]
		public HtmlOptionsCollection Options
		{
			get {
				return default(HtmlOptionsCollection);
			}
		}

		public void Remove()
		{
		}

		public void Remove(int index)
		{
		}

		public void RemoveEventListener(SelectElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(SelectElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(SelectElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(SelectElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener)
		{
		}

		public void RemoveEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(SelectElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(SelectElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture)
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
		public int SelectedIndex
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public ElementCollection SelectedOptions
		{
			get {
				return default(ElementCollection);
			}
		}

		public void SetCustomValidity(string error)
		{
		}

		[FieldProperty]
		public int Size
		{
			get {
				return 0;
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
