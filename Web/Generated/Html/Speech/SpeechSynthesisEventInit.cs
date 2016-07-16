using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, Serializable]
	public partial class SpeechSynthesisEventInit : EventInit {
		public int CharIndex {
			get;
			set;
		}

		public double ElapsedTime {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}
	}
}
