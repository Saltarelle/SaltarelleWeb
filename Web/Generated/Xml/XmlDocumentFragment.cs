using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("DocumentFragment")]
	public partial class XmlDocumentFragment : XmlNode {
		public XmlDocumentFragment() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener, bool capture) {
		}

		[IntrinsicProperty]
		public uint ChildElementCount {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ElementCollection Children {
			get {
				return default(ElementCollection);
			}
		}

		[IntrinsicProperty]
		public XmlElement FirstElementChild {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public XmlElement LastElementChild {
			get {
				return default(XmlElement);
			}
		}

		public XmlElement QuerySelector(string selectors) {
			return default(XmlElement);
		}

		public XmlNodeList QuerySelectorAll(string selectors) {
			return default(XmlNodeList);
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener, bool capture) {
		}
	}
}
