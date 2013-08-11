// SpeechRecognitionError.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionError : Event {
		internal SpeechRecognitionError() {
		}

		public SpeechRecognitionError(string type) {
		}

		public SpeechRecognitionError(string type, SpeechRecognitionErrorInit eventInitDict) {
		}

		[IntrinsicProperty]
		public SpeechRecognitionErrorCode Error {
			get { return default(SpeechRecognitionErrorCode); }
		}

		[IntrinsicProperty]
		public string Message {
			get { return null; }
		}
	}
}
