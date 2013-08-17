using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'PARAM'"), ScriptName("Element")]
	public partial class ParamElement : Element {
		internal ParamElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ParamElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ParamElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ParamElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ParamElement> listener, bool capture) {
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
		public string Value {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string ValueType {
			get {
				return null;
			}
			set {
			}
		}
	}
}
