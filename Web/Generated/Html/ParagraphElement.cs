using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'P'"), ScriptName("Element")]
	public partial class ParagraphElement : Element {
		internal ParagraphElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ParagraphElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ParagraphElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Align {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ParagraphElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ParagraphElement> listener, bool capture) {
		}
	}
}
