using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'PRE'"), ScriptName("Element")]
	public partial class PreElement : Element {
		internal PreElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<PreElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<PreElement> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<PreElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<PreElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public int Width {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
