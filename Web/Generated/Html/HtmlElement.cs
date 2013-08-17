using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'HTML'"), ScriptName("Element")]
	public partial class HtmlElement : Element {
		internal HtmlElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<HtmlElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<HtmlElement> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HtmlElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HtmlElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Version {
			get {
				return null;
			}
			set {
			}
		}
	}
}
