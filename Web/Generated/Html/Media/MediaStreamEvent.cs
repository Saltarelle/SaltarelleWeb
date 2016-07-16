using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaStreamEvent : Event {
		internal MediaStreamEvent() {
		}

		public MediaStreamEvent(string type) {
		}

		public MediaStreamEvent(string type, MediaStreamEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public MediaStream Stream {
			get {
				return default(MediaStream);
			}
		}
	}
}
