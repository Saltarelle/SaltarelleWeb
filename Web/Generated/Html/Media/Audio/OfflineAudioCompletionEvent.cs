using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class OfflineAudioCompletionEvent : Event {
		internal OfflineAudioCompletionEvent() {
		}

		[IntrinsicProperty]
		public AudioBuffer RenderedBuffer {
			get { return default(AudioBuffer); }
		}
	}
}
