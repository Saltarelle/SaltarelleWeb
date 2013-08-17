using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'BASE'"), ScriptName("Element")]
	public partial class BaseElement : Element {
		internal BaseElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<BaseElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<BaseElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Href {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BaseElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BaseElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Target {
			get {
				return null;
			}
			set {
			}
		}
	}
}
