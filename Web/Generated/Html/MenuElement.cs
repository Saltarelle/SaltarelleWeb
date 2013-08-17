using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'MENU'"), ScriptName("Element")]
	public partial class MenuElement : Element {
		internal MenuElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<MenuElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<MenuElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Compact {
			get {
				return false;
			}
			set {
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

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MenuElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MenuElement> listener, bool capture) {
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
