using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CompositionEvent : UIEvent {
		internal CompositionEvent() {
		}

		[IntrinsicProperty]
		public string Data {
			get {
				return null;
			}
		}

		public void InitCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, WindowInstance viewArg, string dataArg, string localeArg) {
		}

		[IntrinsicProperty]
		public string Locale {
			get {
				return null;
			}
		}
	}
}
