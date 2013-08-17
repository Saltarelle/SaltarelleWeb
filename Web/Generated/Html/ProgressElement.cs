using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'PROGRESS'"), ScriptName("Element")]
	public partial class ProgressElement : Element {
		internal ProgressElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public double Max {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double Position {
			get {
				return 0;
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public double Value {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
