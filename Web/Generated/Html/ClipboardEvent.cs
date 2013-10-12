using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ClipboardEvent : Event {
		internal ClipboardEvent() {
		}

		public ClipboardEvent(string type) {
		}

		public ClipboardEvent(string type, ClipboardEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public DataTransfer ClipboardData {
			get {
				return default(DataTransfer);
			}
		}
	}
}
