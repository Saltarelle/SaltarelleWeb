using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionError : Event {
		internal SpeechRecognitionError() {
		}

		public SpeechRecognitionError(string type) {
		}

		public SpeechRecognitionError(string type, SpeechRecognitionErrorInit eventInitDict) {
		}

		[IntrinsicProperty]
		public SpeechRecognitionErrorCode Error {
			get { return default(SpeechRecognitionErrorCode); }
		}

		[IntrinsicProperty]
		public string Message {
			get { return null; }
		}
	}
}
