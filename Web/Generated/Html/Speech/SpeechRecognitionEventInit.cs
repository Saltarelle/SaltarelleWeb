using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Speech {
	[Imported, Serializable]
	public partial class SpeechRecognitionEventInit : EventInit {
		public DocumentBase Emma {
			get;
			set;
		}

		public string Interpretation {
			get;
			set;
		}

		public int ResultIndex {
			get;
			set;
		}

		public object Results {
			get;
			set;
		}
	}
}
