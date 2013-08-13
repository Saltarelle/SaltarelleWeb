using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TEXTAREA'"), ScriptName("Element")]
	public partial class TextAreaElement : Element {
		internal TextAreaElement() {
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
		public uint Cols {
			get {
				return 0;
			}
			set {
			}
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
		public int MaxLength {
			get {
				return 0;
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

		[IntrinsicProperty]
		public string Placeholder {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool ReadOnly {
			get {
				return false;
			}
			set {
			}
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
		public uint Rows {
			get {
				return 0;
			}
			set {
			}
		}

		public void Select() {
		}

		[IntrinsicProperty]
		public string SelectionDirection {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public uint SelectionEnd {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public uint SelectionStart {
			get {
				return 0;
			}
			set {
			}
		}

		public void SetCustomValidity(string error) {
		}

		public void SetSelectionRange(uint start, uint end) {
		}

		public void SetSelectionRange(uint start, uint end, string direction) {
		}

		[IntrinsicProperty]
		public uint TextLength {
			get {
				return 0;
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

		[IntrinsicProperty]
		public string Wrap {
			get {
				return null;
			}
			set {
			}
		}
	}
}
