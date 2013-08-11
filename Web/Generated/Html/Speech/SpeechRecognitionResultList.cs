// SpeechRecognitionResultList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionResultList {
		internal SpeechRecognitionResultList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SpeechRecognitionResult this[uint index] {
			get { return default(SpeechRecognitionResult); }
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SpeechRecognitionResult> GetEnumerator() {
			return default(IEnumerator<SpeechRecognitionResult>);
		}

		public SpeechRecognitionResult Item(uint index) {
			return default(SpeechRecognitionResult);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}
	}
}
