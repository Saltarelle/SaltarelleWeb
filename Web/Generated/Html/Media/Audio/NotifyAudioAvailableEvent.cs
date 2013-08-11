using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class NotifyAudioAvailableEvent : Event {
		internal NotifyAudioAvailableEvent() {
		}

		[IntrinsicProperty]
		public Float32Array FrameBuffer {
			get { return default(Float32Array); }
		}

		public void InitAudioAvailableEvent(string type, bool canBubble, bool cancelable, float[] frameBuffer, uint frameBufferLength, float time, bool allowAudioData) {
		}

		[IntrinsicProperty]
		public float Time {
			get { return 0; }
		}
	}
}
