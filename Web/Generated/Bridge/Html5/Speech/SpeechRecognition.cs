namespace Bridge.Html5.Speech
{
	[Namespace("false"), External]
	public partial class SpeechRecognition : EventTarget
	{
		public extern SpeechRecognition();

		public extern void Abort();

		public extern void AddEventListener(SpeechRecognitionEvents type, Action listener);

		public extern void AddEventListener(SpeechRecognitionEvents type, Action listener, bool capture);

		public extern void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener);

		public extern void AddEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture);

		public extern void AddEventListener(SpeechRecognitionEvents type, IEventListener listener);

		public extern void AddEventListener(SpeechRecognitionEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture);

		public bool Continuous;

		public SpeechGrammarList Grammars;

		public bool InterimResults;

		public string Lang;

		public int MaxAlternatives;

		[Name("onaudioend")]
		public HtmlEventHandler OnAudioend;

		[Name("onaudiostart")]
		public HtmlEventHandler OnAudiostart;

		[Name("onend")]
		public HtmlEventHandler OnEnd;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onnomatch")]
		public HtmlEventHandler OnNomatch;

		[Name("onresult")]
		public HtmlEventHandler OnResult;

		[Name("onsoundend")]
		public HtmlEventHandler OnSoundend;

		[Name("onsoundstart")]
		public HtmlEventHandler OnSoundstart;

		[Name("onspeechend")]
		public HtmlEventHandler OnSpeechend;

		[Name("onspeechstart")]
		public HtmlEventHandler OnSpeechstart;

		[Name("onstart")]
		public HtmlEventHandler OnStart;

		public extern void RemoveEventListener(SpeechRecognitionEvents type, Action listener);

		public extern void RemoveEventListener(SpeechRecognitionEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener);

		public extern void RemoveEventListener(SpeechRecognitionEvents type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture);

		public extern void RemoveEventListener(SpeechRecognitionEvents type, IEventListener listener);

		public extern void RemoveEventListener(SpeechRecognitionEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechRecognition> listener, bool capture);

		public string ServiceURI;

		public extern void Start();

		public extern void Stop();
	}
}
