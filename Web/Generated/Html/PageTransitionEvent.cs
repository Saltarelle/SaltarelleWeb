using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class PageTransitionEvent : Event {
		internal PageTransitionEvent() {
		}

		public PageTransitionEvent(string type) {
		}

		public PageTransitionEvent(string type, PageTransitionEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public bool Persisted {
			get {
				return false;
			}
		}
	}
}
