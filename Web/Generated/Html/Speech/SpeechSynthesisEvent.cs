using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechSynthesisEvent : Event {
		internal SpeechSynthesisEvent() {
		}

		public SpeechSynthesisEvent(string type) {
		}

		public SpeechSynthesisEvent(string type, SpeechSynthesisEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public int CharIndex {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public double ElapsedTime {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
		}
	}
}
