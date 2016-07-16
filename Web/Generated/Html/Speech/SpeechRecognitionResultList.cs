﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionResultList {
		internal SpeechRecognitionResultList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SpeechRecognitionResult this[int index] {
			get {
				return default(SpeechRecognitionResult);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SpeechRecognitionResult> GetEnumerator() {
			return null;
		}

		public SpeechRecognitionResult Item(int index) {
			return default(SpeechRecognitionResult);
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}
	}
}
