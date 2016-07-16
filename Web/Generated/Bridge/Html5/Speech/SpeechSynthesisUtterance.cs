namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechSynthesisUtterance : EventTarget
	{
		public extern SpeechSynthesisUtterance();

		public extern SpeechSynthesisUtterance(string text);

		public extern void AddEventListener(SpeechSynthesisUtteranceEvents type, Action listener);

		public extern void AddEventListener(SpeechSynthesisUtteranceEvents type, Action listener, bool capture);

		public extern void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener);

		public extern void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture);

		public extern void AddEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener);

		public extern void AddEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture);

		[FieldProperty]
		public extern string Lang
		{
			get;
			set;
		}

		[FieldProperty, Name("onboundary")]
		public extern HtmlEventHandler OnBoundary
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

		[FieldProperty, Name("onmark")]
		public extern HtmlEventHandler OnMark
		{
			get;
			set;
		}

		[FieldProperty, Name("onpause")]
		public extern HtmlEventHandler OnPause
		{
			get;
			set;
		}

		[FieldProperty, Name("onresume")]
		public extern HtmlEventHandler OnResume
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

		[FieldProperty]
		public extern double Pitch
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Rate
		{
			get;
			set;
		}

		public extern void RemoveEventListener(SpeechSynthesisUtteranceEvents type, Action listener);

		public extern void RemoveEventListener(SpeechSynthesisUtteranceEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener);

		public extern void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture);

		public extern void RemoveEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener);

		public extern void RemoveEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture);

		[FieldProperty]
		public extern string Text
		{
			get;
			set;
		}

		[FieldProperty]
		public extern SpeechSynthesisVoice Voice
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Volume
		{
			get;
			set;
		}
	}
}
