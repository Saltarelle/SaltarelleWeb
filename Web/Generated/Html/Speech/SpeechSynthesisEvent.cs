// SpeechSynthesisEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

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
		public uint CharIndex {
			get { return 0; }
		}

		[IntrinsicProperty]
		public float ElapsedTime {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
		}
	}
}
