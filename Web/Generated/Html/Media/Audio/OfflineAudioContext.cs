using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class OfflineAudioContext : AudioContext {
		internal OfflineAudioContext() {
		}

		public OfflineAudioContext(uint numberOfChannels, uint length, float sampleRate) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener, bool capture) {
		}

		[IntrinsicProperty, ScriptName("oncomplete")]
		public HtmlEventHandler OnComplete {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener, bool capture) {
		}

		public void StartRendering() {
		}
	}
}
