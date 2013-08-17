using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'UL'"), ScriptName("Element")]
	public partial class UListElement : Element {
		internal UListElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<UListElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<UListElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Compact {
			get {
				return false;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<UListElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<UListElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Type {
			get {
				return null;
			}
			set {
			}
		}
	}
}
