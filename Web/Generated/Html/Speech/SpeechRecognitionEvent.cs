using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionEvent : Event {
		internal SpeechRecognitionEvent() {
		}

		public SpeechRecognitionEvent(string type) {
		}

		public SpeechRecognitionEvent(string type, SpeechRecognitionEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public DocumentBase Emma {
			get {
				return default(DocumentBase);
			}
		}

		[IntrinsicProperty]
		public string Interpretation {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public int ResultIndex {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public object Results {
			get {
				return null;
			}
		}
	}
}
