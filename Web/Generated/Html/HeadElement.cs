using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'HEAD'"), ScriptName("Element")]
	public partial class HeadElement : Element {
		internal HeadElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<HeadElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<HeadElement> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HeadElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HeadElement> listener, bool capture) {
		}
	}
}
