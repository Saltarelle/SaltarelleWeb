using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechSynthesisUtterance : EventTarget {
		public SpeechSynthesisUtterance() {
		}

		public SpeechSynthesisUtterance(string text) {
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, Action listener) {
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener) {
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture) {
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener) {
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Lang {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onboundary")]
		public HtmlEventHandler OnBoundary {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onend")]
		public HtmlEventHandler OnEnd {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmark")]
		public HtmlEventHandler OnMark {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpause")]
		public HtmlEventHandler OnPause {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onresume")]
		public HtmlEventHandler OnResume {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onstart")]
		public HtmlEventHandler OnStart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double Pitch {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double Rate {
			get {
				return 0;
			}
			set {
			}
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, Action listener) {
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener) {
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture) {
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Text {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public SpeechSynthesisVoice Voice {
			get {
				return default(SpeechSynthesisVoice);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double Volume {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
