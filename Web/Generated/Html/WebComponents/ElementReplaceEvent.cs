using System.Runtime.CompilerServices;

namespace System.Html.WebComponents {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ElementReplaceEvent : Event {
		internal ElementReplaceEvent() {
		}

		public ElementReplaceEvent(string type) {
		}

		public ElementReplaceEvent(string type, ElementReplaceEventInit eventInitDict) {
		}

		public void InitElementReplaceEvent(string type, bool canBubble, bool cancelable, Element upgrade) {
		}

		[IntrinsicProperty]
		public Element Upgrade {
			get {
				return default(Element);
			}
		}
	}
}
