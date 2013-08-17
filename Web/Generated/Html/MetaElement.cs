using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'META'"), ScriptName("Element")]
	public partial class MetaElement : Element {
		internal MetaElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<MetaElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<MetaElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Content {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string HttpEquiv {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MetaElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MetaElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Scheme {
			get {
				return null;
			}
			set {
			}
		}
	}
}
