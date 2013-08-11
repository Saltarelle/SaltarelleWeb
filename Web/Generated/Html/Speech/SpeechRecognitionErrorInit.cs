using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, Serializable]
	public partial class SpeechRecognitionErrorInit : EventInit {
		public SpeechRecognitionErrorCode Error {
			get { return default(SpeechRecognitionErrorCode); }
			set { }
		}

		public string Message {
			get { return null; }
			set { }
		}
	}
}
