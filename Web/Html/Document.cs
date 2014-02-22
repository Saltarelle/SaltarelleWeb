using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	public partial class Document {
		public static void AddEventListener(string type, Action listener) {}
		public static void AddEventListener(string type, Action listener, bool capture) {}
		public static void AddEventListener(string type, Action listener, bool capture, bool? wantsUntrusted) {}

		public static void RemoveEventListener(string type, Action listener) {}
		public static void RemoveEventListener(string type, Action listener, bool capture) {}


		public static void AddEventListener(string type, HtmlEventHandler listener) {}
		public static void AddEventListener(string type, HtmlEventHandler listener, bool capture) {}
		public static void AddEventListener(string type, HtmlEventHandler listener, bool capture, bool? wantsUntrusted) {}

		public static void RemoveEventListener(string type, HtmlEventHandler listener) {}
		public static void RemoveEventListener(string type, HtmlEventHandler listener, bool capture) {}

		[IntrinsicProperty]
		public static Element ActiveElement {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public static ElementCollection Children {
			get {
				return default(ElementCollection);
			}
		}

		public static Element CreateElement(string localName) {
			return default(Element);
		}

		public static Element CreateElementNS(string @namespace, string qualifiedName) {
			return default(Element);
		}

		[IntrinsicProperty]
		public static Element CurrentScript {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public static Element DocumentElement {
			get {
				return default(Element);
			}
		}

		public static Element ElementFromPoint(float x, float y) {
			return default(Element);
		}

		[IntrinsicProperty]
		public static Element FirstElementChild {
			get {
				return default(Element);
			}
		}

		public static Element GetAnonymousElementByAttribute(Element elt, string attrName, string attrValue) {
			return default(Element);
		}

		public static Element GetBindingParent(XmlNode node) {
			return default(Element);
		}

		public static Element GetElementById(string elementId) {
			return default(Element);
		}

		public static ElementCollection GetElementsByClassName(string classNames) {
			return default(ElementCollection);
		}

		public static ElementCollection GetElementsByTagName(string localName) {
			return default(ElementCollection);
		}

		public static ElementCollection GetElementsByTagNameNS(string @namespace, string localName) {
			return default(ElementCollection);
		}
		
		[IntrinsicProperty]
		public static Element LastElementChild {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public static Element ParentElement {
			get {
				return default(Element);
			}
		}
		
		public static Element QuerySelector(string selectors) {
			return default(Element);
		}
	}
}