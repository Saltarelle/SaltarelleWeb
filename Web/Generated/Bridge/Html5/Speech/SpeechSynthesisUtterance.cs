namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechSynthesisUtterance : EventTarget
	{
		public SpeechSynthesisUtterance()
		{
		}

		public SpeechSynthesisUtterance(string text)
		{
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, Action listener)
		{
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener)
		{
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture)
		{
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture)
		{
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

		[FieldProperty, Name("onboundary")]
		public HtmlEventHandler OnBoundary
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

		[FieldProperty, Name("onmark")]
		public HtmlEventHandler OnMark
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpause")]
		public HtmlEventHandler OnPause
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onresume")]
		public HtmlEventHandler OnResume
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

		[FieldProperty]
		public double Pitch
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public double Rate
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, Action listener)
		{
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener)
		{
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture)
		{
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(SpeechSynthesisUtteranceEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpeechSynthesisUtterance> listener, bool capture)
		{
		}

		[FieldProperty]
		public string Text
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public SpeechSynthesisVoice Voice
		{
			get {
				return default(SpeechSynthesisVoice);
			}
			set {
			}
		}

		[FieldProperty]
		public double Volume
		{
			get {
				return 0;
			}
			set {
			}
		}
	}
}
