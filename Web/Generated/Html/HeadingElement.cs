using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'H1' || {this}.tagName === 'H2' || {this}.tagName === 'H3' || {this}.tagName === 'H4' || {this}.tagName === 'H5' || {this}.tagName === 'H6')"), ScriptName("Element")]
	public partial class HeadingElement : Element {
		internal HeadingElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<HeadingElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<HeadingElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Align {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HeadingElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HeadingElement> listener, bool capture) {
		}
	}
}
