using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DATA'"), ScriptName("Element")]
	public partial class DataElement : Element {
		internal DataElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DataElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DataElement> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DataElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DataElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Value {
			get {
				return null;
			}
			set {
			}
		}
	}
}
