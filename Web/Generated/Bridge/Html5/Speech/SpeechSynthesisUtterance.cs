namespace Bridge.Html5.Speech
{
	[Namespace(false), External]
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

		public string Lang;

		[Name("onboundary")]
		public HtmlEventHandler OnBoundary;

		[Name("onend")]
		public HtmlEventHandler OnEnd;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onmark")]
		public HtmlEventHandler OnMark;

		[Name("onpause")]
		public HtmlEventHandler OnPause;

		[Name("onresume")]
		public HtmlEventHandler OnResume;

		[Name("onstart")]
		public HtmlEventHandler OnStart;

		public double Pitch;

		public double Rate;

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

		public string Text;

		public SpeechSynthesisVoice Voice;

		public double Volume;
	}
}
