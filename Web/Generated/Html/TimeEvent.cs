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

		[IntrinsicProperty]
		public WindowInstance View {
			get {
				return default(WindowInstance);
			}
		}
	}
}
