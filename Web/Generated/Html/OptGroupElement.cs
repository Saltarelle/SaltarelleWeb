using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OPTGROUP'"), ScriptName("Element")]
	public partial class OptGroupElement : Element {
		internal OptGroupElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<OptGroupElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<OptGroupElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Disabled {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Label {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OptGroupElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OptGroupElement> listener, bool capture) {
		}
	}
}
