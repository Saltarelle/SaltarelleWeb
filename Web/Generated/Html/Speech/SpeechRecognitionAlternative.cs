using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionAlternative {
		internal SpeechRecognitionAlternative() {
		}

		[IntrinsicProperty]
		public float Confidence {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string Transcript {
			get {
				return null;
			}
		}
	}
}
