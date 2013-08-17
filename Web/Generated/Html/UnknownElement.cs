using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("HTMLUnknownElement")]
	public partial class UnknownElement : Element {
		internal UnknownElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<UnknownElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<UnknownElement> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<UnknownElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<UnknownElement> listener, bool capture) {
		}
	}
}
