using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, Serializable]
	public partial class SpeechSynthesisEventInit : EventInit {
		public uint CharIndex {
			get;
			set;
		}

		public float ElapsedTime {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}
	}
}
