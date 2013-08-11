// SpeechRecognitionErrorInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, Serializable]
	public partial class SpeechRecognitionErrorInit : EventInit {
		public SpeechRecognitionErrorCode Error {
			get { return default(SpeechRecognitionErrorCode); }
			set { }
		}

		public string Message {
			get { return null; }
			set { }
		}
	}
}
