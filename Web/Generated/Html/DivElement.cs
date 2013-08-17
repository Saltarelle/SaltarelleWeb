using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DIV'"), ScriptName("Element")]
	public partial class DivElement : Element {
		internal DivElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DivElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DivElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Align {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DivElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DivElement> listener, bool capture) {
		}
	}
}
