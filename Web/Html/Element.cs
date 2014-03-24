using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class Element {
		[ScriptSkip]
		public TElement As<TElement>() where TElement : Element {
			return null;
		}

		[ScriptName("id"), Obsolete("Use property Id instead")]
		public string ID { get; set; }

		public Element AppendChild(Element element) {
			return default(Element);
		}

		[IntrinsicProperty]
		public ElementCollection Children {
			get {
				return default(ElementCollection);
			}
		}

		public Element CloneNode() {
			return default(Element);
		}

		public Element CloneNode(bool deep) {
			return default(Element);
		}

		[IntrinsicProperty]
		public Element FirstElementChild {
			get {
				return default(Element);
			}
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

		public Element InsertBefore(Element node, Element child) {
			return default(Element);
		}

		[IntrinsicProperty]
		public Element LastElementChild {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public Element NextElementSibling {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public Element ParentElement {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public Element PreviousElementSibling {
			get {
				return default(Element);
			}
		}

		public Element QuerySelector(string selectors) {
			return default(Element);
		}

		public ElementNodeList QuerySelectorAll(string selectors) {
			return default(ElementNodeList);
		}

		public Element RemoveChild(Element element) {
			return default(Element);
		}
	}
}