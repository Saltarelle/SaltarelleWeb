using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TITLE'"), ScriptName("Element")]
	public partial class TitleElement : Element {
		internal TitleElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TitleElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TitleElement> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TitleElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TitleElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Text {
			get {
				return null;
			}
			set {
			}
		}
	}
}
