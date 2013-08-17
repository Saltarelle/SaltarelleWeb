using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'LI'"), ScriptName("Element")]
	public partial class LIElement : Element {
		internal LIElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<LIElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<LIElement> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LIElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LIElement> listener, bool capture) {
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
		public int Value {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
