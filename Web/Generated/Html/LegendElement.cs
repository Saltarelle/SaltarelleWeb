using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'LEGEND'"), ScriptName("Element")]
	public partial class LegendElement : Element {
		internal LegendElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<LegendElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<LegendElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Align {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public FormElement Form {
			get {
				return default(FormElement);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LegendElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LegendElement> listener, bool capture) {
		}
	}
}
