using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'STYLE'"), ScriptName("Element")]
	public partial class StyleElement : Element {
		internal StyleElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<StyleElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<StyleElement> listener, bool capture) {
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
		public string Media {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<StyleElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<StyleElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Scoped {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public StyleSheet Sheet {
			get {
				return default(StyleSheet);
			}
		}

		[IntrinsicProperty]
		public string Type {
			get {
				return null;
			}
			set {
			}
		}
	}
}
