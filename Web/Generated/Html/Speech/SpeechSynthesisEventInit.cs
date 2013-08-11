// SpeechSynthesisEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, Serializable]
	public partial class SpeechSynthesisEventInit : EventInit {
		public uint CharIndex {
			get { return 0; }
			set { }
		}

		public float ElapsedTime {
			get { return 0; }
			set { }
		}

		public string Name {
			get { return null; }
			set { }
		}
	}
}
