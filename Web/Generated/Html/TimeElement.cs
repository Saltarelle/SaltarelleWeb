using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TIME'"), ScriptName("Element")]
	public partial class TimeElement : Element {
		internal TimeElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TimeElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TimeElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string DateTime {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TimeElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TimeElement> listener, bool capture) {
		}
	}
}
