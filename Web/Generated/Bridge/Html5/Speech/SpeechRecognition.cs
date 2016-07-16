namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognition : EventTarget
	{
		public SpeechRecognition()
		{
		}

		public void Abort()
		{
		}

		public void AddEventListener(SpeechRecognitionEvents type, Action listener)
		{
		}

		public void AddEventListener(SpeechRecognitionEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener)
		{
		}

		public void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture)
		{
		}

		public void AddEventListener(SpeechRecognitionEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(SpeechRecognitionEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture)
		{
		}

		[FieldProperty]
		public bool Continuous
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public SpeechGrammarList Grammars
		{
			get {
				return default(SpeechGrammarList);
			}
			set {
			}
		}

		[FieldProperty]
		public bool InterimResults
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public string Lang
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public int MaxAlternatives
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty, Name("onaudioend")]
		public HtmlEventHandler OnAudioend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onaudiostart")]
		public HtmlEventHandler OnAudiostart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onend")]
		public HtmlEventHandler OnEnd
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onerror")]
		public HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onnomatch")]
		public HtmlEventHandler OnNomatch
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onresult")]
		public HtmlEventHandler OnResult
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsoundend")]
		public HtmlEventHandler OnSoundend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsoundstart")]
		public HtmlEventHandler OnSoundstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onspeechend")]
		public HtmlEventHandler OnSpeechend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onspeechstart")]
		public HtmlEventHandler OnSpeechstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onstart")]
		public HtmlEventHandler OnStart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, Action listener)
		{
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener)
		{
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture)
		{
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(SpeechRecognitionEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture)
		{
		}

		[FieldProperty]
		public string ServiceURI
		{
			get {
				return null;
			}
			set {
			}
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}
	}
}
