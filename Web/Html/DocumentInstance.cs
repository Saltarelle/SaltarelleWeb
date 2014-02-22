using System.Xml;
using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class DocumentInstance {
		[IntrinsicProperty]
		public Element ActiveElement {
			get {
				return null;
			}
		}

		public Element CreateElement(string localName) {
			return null;
		}

		public Element CreateElementNS(string @namespace, string qualifiedName) {
			return null;
		}

		[IntrinsicProperty]
		public Element CurrentScript {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public Element DocumentElement {
			get {
				return null;
			}
		}

		public Element ElementFromPoint(float x, float y) {
			return null;
		}

		[IntrinsicProperty]
		public Element FirstElementChild {
			get {
				return null;
			}
		}

		public Element GetAnonymousElementByAttribute(XmlElement elt, string attrName, string attrValue) {
			return null;
		}

		public Element GetAnonymousNodes(XmlElement elt) {
			return null;
		}

		public Element GetBindingParent(XmlNode node) {
			return null;
		}

		public Element GetElementById(string elementId) {
			return null;
		}

		[IntrinsicProperty]
		public Element LastElementChild {
			get {
				return null;
			}
		}

		public Element QuerySelector(string selectors) {
			return null;
		}
	}
}