using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class BeforeUnloadEvent : Event {
		internal BeforeUnloadEvent() {
		}

		[IntrinsicProperty]
		public string ReturnValue {
			get {
				return null;
			}
			set {
			}
		}
	}
}
