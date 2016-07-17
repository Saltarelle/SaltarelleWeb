namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External]
	public partial class OfflineAudioContext : AudioContext
	{
		internal extern OfflineAudioContext();

		public extern OfflineAudioContext(int numberOfChannels, int length, double sampleRate);

		public extern void AddEventListener(OfflineAudioContextEvents type, Action listener);

		public extern void AddEventListener(OfflineAudioContextEvents type, Action listener, bool capture);

		public extern void AddEventListener(OfflineAudioContextEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(OfflineAudioContextEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(OfflineAudioContextEvents type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener);

		public extern void AddEventListener(OfflineAudioContextEvents type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener, bool capture);

		public extern void AddEventListener(OfflineAudioContextEvents type, IEventListener listener);

		public extern void AddEventListener(OfflineAudioContextEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener, bool capture);

		[Name("oncomplete")]
		public HtmlEventHandler OnComplete;

		public extern void RemoveEventListener(OfflineAudioContextEvents type, Action listener);

		public extern void RemoveEventListener(OfflineAudioContextEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(OfflineAudioContextEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(OfflineAudioContextEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(OfflineAudioContextEvents type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener);

		public extern void RemoveEventListener(OfflineAudioContextEvents type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener, bool capture);

		public extern void RemoveEventListener(OfflineAudioContextEvents type, IEventListener listener);

		public extern void RemoveEventListener(OfflineAudioContextEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OfflineAudioContext> listener, bool capture);

		public extern void StartRendering();
	}
}
