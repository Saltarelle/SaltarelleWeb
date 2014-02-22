using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class Element {
		[ScriptSkip]
		public TElement As<TElement>() where TElement : Element {
			return null;
		}

		[ScriptName("id"), Obsolete("Use property Id instead")]
		public string ID { get; set; }

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
	}
}