using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DL'"), ScriptName("Element")]
	public partial class DListElement : Element {
		internal DListElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DListElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DListElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Compact {
			get {
				return false;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DListElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DListElement> listener, bool capture) {
		}
	}
}
