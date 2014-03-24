using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechGrammarList {
		internal SpeechGrammarList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SpeechGrammar this[int index] {
			get {
				return default(SpeechGrammar);
			}
		}

		public void AddFromString(string @string) {
		}

		public void AddFromString(string @string, float weight) {
		}

		public void AddFromURI(string src) {
		}

		public void AddFromURI(string src, float weight) {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SpeechGrammar> GetEnumerator() {
			return null;
		}

		public SpeechGrammar Item(int index) {
			return default(SpeechGrammar);
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}
	}
}
