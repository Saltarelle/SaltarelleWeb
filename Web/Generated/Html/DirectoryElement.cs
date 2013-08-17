using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DIR'"), ScriptName("Element")]
	public partial class DirectoryElement : Element {
		internal DirectoryElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DirectoryElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DirectoryElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Compact {
			get {
				return false;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DirectoryElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DirectoryElement> listener, bool capture) {
		}
	}
}
