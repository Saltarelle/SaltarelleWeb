using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FONT'"), ScriptName("Element")]
	public partial class FontElement : Element {
		internal FontElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<FontElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<FontElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Color {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Face {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FontElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FontElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Size {
			get {
				return null;
			}
			set {
			}
		}
	}
}
