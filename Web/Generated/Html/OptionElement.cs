using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OPTION'"), ScriptName("Element")]
	public partial class OptionElement : Element {
		[InlineCode("new Option()")]
		public OptionElement() {
		}

		[InlineCode("new Option({text})")]
		public OptionElement(string text) {
		}

		[InlineCode("new Option({text}, {value})")]
		public OptionElement(string text, string value) {
		}

		[InlineCode("new Option({text}, {value}, {defaultSelected})")]
		public OptionElement(string text, string value, bool defaultSelected) {
		}

		[InlineCode("new Option({text}, {value}, {defaultSelected}, {selected})")]
		public OptionElement(string text, string value, bool defaultSelected, bool selected) {
		}

		[IntrinsicProperty]
		public bool DefaultSelected {
			get {
				return false;
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
		public int Index {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string Label {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Selected {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Text {
			get {
				return null;
			}
			set {
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
	}
}
