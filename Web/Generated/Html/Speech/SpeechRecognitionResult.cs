using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionResult {
		internal SpeechRecognitionResult() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SpeechRecognitionAlternative this[uint index] {
			get {
				return default(SpeechRecognitionAlternative);
			}
		}

		[IntrinsicProperty]
		public bool Final {
			get {
				return false;
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SpeechRecognitionAlternative> GetEnumerator() {
			return null;
		}

		public SpeechRecognitionAlternative Item(uint index) {
			return default(SpeechRecognitionAlternative);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}
	}
}
