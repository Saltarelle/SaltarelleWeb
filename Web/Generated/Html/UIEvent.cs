using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class UIEvent : Event {
		internal UIEvent() {
		}

		public UIEvent(string type) {
		}

		public UIEvent(string type, UIEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public bool CancelBubble {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int Detail {
			get {
				return 0;
			}
		}

		public void InitUIEvent(string aType, bool aCanBubble, bool aCancelable, WindowInstance aView, int aDetail) {
		}

		[IntrinsicProperty]
		public bool IsChar {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public int LayerX {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int LayerY {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int PageX {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int PageY {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int RangeOffset {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public XmlNode RangeParent {
			get {
				return default(XmlNode);
			}
		}

		[ScriptName("SCROLL_PAGE_DOWN")]
		public const int SCROLL_PAGE_DOWN = 32768;

		[ScriptName("SCROLL_PAGE_UP")]
		public const int SCROLL_PAGE_UP = -32768;

		[IntrinsicProperty]
		public WindowInstance View {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public uint Which {
			get {
				return 0;
			}
		}
	}
}
