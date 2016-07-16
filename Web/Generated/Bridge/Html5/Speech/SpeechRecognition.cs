namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern bool Continuous
		{
			get;
			set;
		}

		[FieldProperty]
		public extern SpeechGrammarList Grammars
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool InterimResults
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Lang
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int MaxAlternatives
		{
			get;
			set;
		}

		[FieldProperty, Name("onaudioend")]
		public extern HtmlEventHandler OnAudioend
		{
			get;
			set;
		}

		[FieldProperty, Name("onaudiostart")]
		public extern HtmlEventHandler OnAudiostart
		{
			get;
			set;
		}

		[FieldProperty, Name("onend")]
		public extern HtmlEventHandler OnEnd
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public extern HtmlEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onnomatch")]
		public extern HtmlEventHandler OnNomatch
		{
			get;
			set;
		}

		[FieldProperty, Name("onresult")]
		public extern HtmlEventHandler OnResult
		{
			get;
			set;
		}

		[FieldProperty, Name("onsoundend")]
		public extern HtmlEventHandler OnSoundend
		{
			get;
			set;
		}

		[FieldProperty, Name("onsoundstart")]
		public extern HtmlEventHandler OnSoundstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onspeechend")]
		public extern HtmlEventHandler OnSpeechend
		{
			get;
			set;
		}

		[FieldProperty, Name("onspeechstart")]
		public extern HtmlEventHandler OnSpeechstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onstart")]
		public extern HtmlEventHandler OnStart
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern string ServiceURI
		{
			get;
			set;
		}

		public extern void Start();

		public extern void Stop();
	}
}
