using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechSynthesis {
		internal SpeechSynthesis() {
		}

		public void Cancel() {
		}

		public SpeechSynthesisVoice[] GetVoices() {
			return null;
		}

		public void Pause() {
		}

		[IntrinsicProperty]
		public bool Paused {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public bool Pending {
			get {
				return false;
			}
		}

		public void Resume() {
		}

		public void Speak(SpeechSynthesisUtterance utterance) {
		}

		[IntrinsicProperty]
		public bool Speaking {
			get {
				return false;
			}
		}
	}
}
