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
		public ElementCollection Children {
			get {
				return default(ElementCollection);
			}
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

		public Element GetElementById(string elementId) {
			return null;
		}

		public ElementCollection GetElementsByClassName(string classNames) {
			return default(ElementCollection);
		}

		public ElementCollection GetElementsByTagName(string localName) {
			return default(ElementCollection);
		}

		public ElementCollection GetElementsByTagNameNS(string @namespace, string localName) {
			return default(ElementCollection);
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

		public ElementNodeList QuerySelectorAll(string selectors) {
			return default(ElementNodeList);
		}
	}
}