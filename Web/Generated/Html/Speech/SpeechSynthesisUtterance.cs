// SpeechSynthesisUtterance.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechSynthesisUtterance : EventTarget {
		public SpeechSynthesisUtterance() {
		}

		public SpeechSynthesisUtterance(string text) {
		}

		[IntrinsicProperty]
		public string Lang {
			get { return null; }
			set { }
		}

		[IntrinsicProperty, ScriptName("onboundary")]
		public HtmlEventHandler OnBoundary {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onend")]
		public HtmlEventHandler OnEnd {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onmark")]
		public HtmlEventHandler OnMark {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onpause")]
		public HtmlEventHandler OnPause {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onresume")]
		public HtmlEventHandler OnResume {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onstart")]
		public HtmlEventHandler OnStart {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty]
		public float Pitch {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public float Rate {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public string Text {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public SpeechSynthesisVoice Voice {
			get { return default(SpeechSynthesisVoice); }
			set { }
		}

		[IntrinsicProperty]
		public float Volume {
			get { return 0; }
			set { }
		}
	}
}
