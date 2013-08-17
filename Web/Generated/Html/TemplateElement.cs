using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TEMPLATE'"), ScriptName("Element")]
	public partial class TemplateElement : Element {
		internal TemplateElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TemplateElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TemplateElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public XmlDocumentFragment Content {
			get {
				return default(XmlDocumentFragment);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TemplateElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TemplateElement> listener, bool capture) {
		}
	}
}
