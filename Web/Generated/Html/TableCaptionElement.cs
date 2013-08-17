using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'CAPTION'"), ScriptName("Element")]
	public partial class TableCaptionElement : Element {
		internal TableCaptionElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TableCaptionElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TableCaptionElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Align {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableCaptionElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableCaptionElement> listener, bool capture) {
		}
	}
}
