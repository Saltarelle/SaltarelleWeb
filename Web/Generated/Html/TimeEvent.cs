using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TimeEvent : Event {
		internal TimeEvent() {
		}

		[IntrinsicProperty]
		public int Detail {
			get {
				return 0;
			}
		}

		public void InitTimeEvent(string aType, WindowInstance aView, int aDetail) {
		}

		[IntrinsicProperty]
		public WindowInstance View {
			get {
				return default(WindowInstance);
			}
		}
	}
}
