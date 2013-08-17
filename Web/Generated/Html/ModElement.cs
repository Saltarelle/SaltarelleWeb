using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'INS' || {this}.tagName === 'DEL')"), ScriptName("Element")]
	public partial class ModElement : Element {
		internal ModElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ModElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ModElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Cite {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string DateTime {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ModElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ModElement> listener, bool capture) {
		}
	}
}
