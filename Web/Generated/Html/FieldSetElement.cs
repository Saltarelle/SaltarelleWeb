using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FIELDSET'"), ScriptName("Element")]
	public partial class FieldSetElement : Element {
		internal FieldSetElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture) {
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

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FieldSetElement> listener, bool capture) {
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
