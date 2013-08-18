using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FIELDSET'"), ScriptName("Element")]
	public partial class FieldSetElement : Element {
		internal FieldSetElement() {
		}

		public void AddEventListener(FieldSetElementEvents type, Action listener) {
		}

		public void AddEventListener(FieldSetElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(FieldSetElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(FieldSetElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener) {
		}

		public void AddEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture) {
		}

		public void AddEventListener(FieldSetElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(FieldSetElementEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture) {
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
		public ElementCollection Elements {
			get {
				return default(ElementCollection);
			}
		}

		[IntrinsicProperty]
		public FormElement Form {
			get {
				return default(FormElement);
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

		public void RemoveEventListener(FieldSetElementEvents type, Action listener) {
		}

		public void RemoveEventListener(FieldSetElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener) {
		}

		public void RemoveEventListener(FieldSetElementEvents type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture) {
		}

		public void RemoveEventListener(FieldSetElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(FieldSetElementEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture) {
		}

		public void SetCustomValidity(string error) {
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
		public bool WillValidate {
			get {
				return false;
			}
		}
	}
}
