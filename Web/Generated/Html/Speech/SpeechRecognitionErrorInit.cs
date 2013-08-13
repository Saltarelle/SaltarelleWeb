using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, Serializable]
	public partial class SpeechRecognitionErrorInit : EventInit {
		public SpeechRecognitionErrorCode Error {
			get;
			set;
		}

		public string Message {
			get;
			set;
		}
	}
}
