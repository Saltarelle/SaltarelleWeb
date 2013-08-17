using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DATALIST'"), ScriptName("Element")]
	public partial class DataListElement : Element {
		internal DataListElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DataListElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DataListElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public ElementCollection Options {
			get {
				return default(ElementCollection);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DataListElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DataListElement> listener, bool capture) {
		}
	}
}
