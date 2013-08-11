using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CompositionEvent : UIEvent {
		internal CompositionEvent() {
		}

		[IntrinsicProperty]
		public string Data {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Locale {
			get { return null; }
		}
	}
}
