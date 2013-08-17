using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'Q'"), ScriptName("Element")]
	public partial class QuoteElement : Element {
		internal QuoteElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<QuoteElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<QuoteElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Cite {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<QuoteElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<QuoteElement> listener, bool capture) {
		}
	}
}
