using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'BUTTON'"), ScriptName("Element")]
	public partial class ButtonElement : Element {
		internal ButtonElement() {
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

		[IntrinsicProperty]
		public string FormAction {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string FormEnctype {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string FormMethod {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool FormNoValidate {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string FormTarget {
			get {
				return null;
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

		public void SetCustomValidity(string error) {
		}

		[IntrinsicProperty]
		public string Type {
			get {
				return null;
			}
			set {
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
