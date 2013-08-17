using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'BR'"), ScriptName("Element")]
	public partial class BRElement : Element {
		internal BRElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<BRElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<BRElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Clear {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BRElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BRElement> listener, bool capture) {
		}
	}
}
