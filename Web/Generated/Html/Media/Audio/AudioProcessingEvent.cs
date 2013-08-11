using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AudioProcessingEvent : Event {
		internal AudioProcessingEvent() {
		}

		[IntrinsicProperty]
		public AudioBuffer InputBuffer {
			get { return default(AudioBuffer); }
		}

		[IntrinsicProperty]
		public AudioBuffer OutputBuffer {
			get { return default(AudioBuffer); }
		}

		[IntrinsicProperty]
		public double PlaybackTime {
			get { return 0; }
		}
	}
}
