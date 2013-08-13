using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OUTPUT'"), ScriptName("Element")]
	public partial class OutputElement : Element {
		internal OutputElement() {
		}

		public bool CheckValidity() {
			return false;
		}

		[IntrinsicProperty]
		public string DefaultValue {
			get {
				return null;
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
		public DOMSettableTokenList HtmlFor {
			get {
				return default(DOMSettableTokenList);
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
