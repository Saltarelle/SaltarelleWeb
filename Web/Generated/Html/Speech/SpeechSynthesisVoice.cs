using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechSynthesisVoice {
		internal SpeechSynthesisVoice() {
		}

		[IntrinsicProperty]
		public bool Default {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public string Lang {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public bool LocalService {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string VoiceURI {
			get {
				return null;
			}
		}
	}
}
