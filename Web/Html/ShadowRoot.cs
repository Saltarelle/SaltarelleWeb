using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class ShadowRoot {
		[IntrinsicProperty]
		public ElementCollection Children {
			get {
				return default(ElementCollection);
			}
		}

		[IntrinsicProperty]
		public Element FirstElementChild {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public Element LastElementChild {
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
	}
}