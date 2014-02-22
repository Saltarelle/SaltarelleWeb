using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'SELECT'"), ScriptName("Element")]
	public partial class SelectElement : Element {
		internal SelectElement() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public TypeOption<Element, OptionElement> this[uint index] {
			get {
				return default(TypeOption<Element, OptionElement>);
			}
			set {
			}
		}

		public void Add(TypeOption<OptionElement, OptGroupElement> element) {
		}

		public void Add(TypeOption<OptionElement, OptGroupElement> element, TypeOption<Element, int> before) {
		}

		public void AddEventListener(SelectElementEvents type, Action listener) {
		}

		public void AddEventListener(SelectElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(SelectElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(SelectElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener) {
		}

		public void AddEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture) {
		}

		public void AddEventListener(SelectElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(SelectElementEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Autofocus {
			get {
				return false;
			}
			set {
			}
		}

		public bool CheckValidity() {
			return false;
		}

		[IntrinsicProperty]
		public bool Disabled {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public FormElement Form {
			get {
				return default(FormElement);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<Element> GetEnumerator() {
			return null;
		}

		public Element Item(uint index) {
			return default(Element);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Multiple {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
			set {
			}
		}

		public OptionElement NamedItem(string name) {
			return default(OptionElement);
		}

		[IntrinsicProperty]
		public HtmlOptionsCollection Options {
			get {
				return default(HtmlOptionsCollection);
			}
		}

		public void Remove() {
		}

		public void Remove(int index) {
		}

		public void RemoveEventListener(SelectElementEvents type, Action listener) {
		}

		public void RemoveEventListener(SelectElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(SelectElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(SelectElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener) {
		}

		public void RemoveEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture) {
		}

		public void RemoveEventListener(SelectElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(SelectElementEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Required {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int SelectedIndex {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public ElementCollection SelectedOptions {
			get {
				return default(ElementCollection);
			}
		}

		public void SetCustomValidity(string error) {
		}

		[IntrinsicProperty]
		public uint Size {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Type {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string ValidationMessage {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public ValidityState Validity {
			get {
				return default(ValidityState);
			}
		}

		[IntrinsicProperty]
		public string Value {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool WillValidate {
			get {
				return false;
			}
		}
	}
}
