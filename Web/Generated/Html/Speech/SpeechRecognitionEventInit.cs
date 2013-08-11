// SpeechRecognitionEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Speech {
	[Imported, Serializable]
	public partial class SpeechRecognitionEventInit : EventInit {
		public DocumentBase Emma {
			get { return default(DocumentBase); }
			set { }
		}

		public string Interpretation {
			get { return null; }
			set { }
		}

		public uint ResultIndex {
			get { return 0; }
			set { }
		}

		public object Results {
			get { return null; }
			set { }
		}
	}
}
