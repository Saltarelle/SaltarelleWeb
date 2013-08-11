// SpeechRecognitionResult.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionResult {
		internal SpeechRecognitionResult() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SpeechRecognitionAlternative this[uint index] {
			get { return default(SpeechRecognitionAlternative); }
		}

		[IntrinsicProperty]
		public bool Final {
			get { return false; }
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SpeechRecognitionAlternative> GetEnumerator() {
			return default(IEnumerator<SpeechRecognitionAlternative>);
		}

		public SpeechRecognitionAlternative Item(uint index) {
			return default(SpeechRecognitionAlternative);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}
	}
}
