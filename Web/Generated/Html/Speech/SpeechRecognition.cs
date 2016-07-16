using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SpeechRecognition : EventTarget {
		public SpeechRecognition() {
		}

		public void Abort() {
		}

		public void AddEventListener(SpeechRecognitionEvents type, Action listener) {
		}

		public void AddEventListener(SpeechRecognitionEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener) {
		}

		public void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture) {
		}

		public void AddEventListener(SpeechRecognitionEvents type, IEventListener listener) {
		}

		public void AddEventListener(SpeechRecognitionEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Continuous {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public SpeechGrammarList Grammars {
			get {
				return default(SpeechGrammarList);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool InterimResults {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Lang {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int MaxAlternatives {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onaudioend")]
		public HtmlEventHandler OnAudioend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onaudiostart")]
		public HtmlEventHandler OnAudiostart {
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

		[IntrinsicProperty, ScriptName("onnomatch")]
		public HtmlEventHandler OnNomatch {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onresult")]
		public HtmlEventHandler OnResult {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsoundend")]
		public HtmlEventHandler OnSoundend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsoundstart")]
		public HtmlEventHandler OnSoundstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onspeechend")]
		public HtmlEventHandler OnSpeechend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onspeechstart")]
		public HtmlEventHandler OnSpeechstart {
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

		public void RemoveEventListener(SpeechRecognitionEvents type, Action listener) {
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener) {
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture) {
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string ServiceURI {
			get {
				return null;
			}
			set {
			}
		}

		public void Start() {
		}

		public void Stop() {
		}
	}
}
