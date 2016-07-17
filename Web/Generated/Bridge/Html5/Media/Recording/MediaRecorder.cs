namespace Bridge.Html5.Media.Recording
{
	[Namespace("false"), External]
	public partial class MediaRecorder : EventTarget
	{
		internal extern MediaRecorder();

		public extern MediaRecorder(MediaStream stream);

		public extern MediaRecorder(MediaStream stream, MediaRecorderOptions options);

		public extern void AddEventListener(MediaRecorderEvents type, Action listener);

		public extern void AddEventListener(MediaRecorderEvents type, Action listener, bool capture);

		public extern void AddEventListener(MediaRecorderEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MediaRecorderEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MediaRecorderEvents type, HtmlEventHandlerWithTarget<MediaRecorder> listener);

		public extern void AddEventListener(MediaRecorderEvents type, HtmlEventHandlerWithTarget<MediaRecorder> listener, bool capture);

		public extern void AddEventListener(MediaRecorderEvents type, IEventListener listener);

		public extern void AddEventListener(MediaRecorderEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaRecorder> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaRecorder> listener, bool capture);

		public readonly string MimeType;

		[Name("ondataavailable")]
		public HtmlEventHandler OnDataavailable;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onstop")]
		public HtmlEventHandler OnStop;

		[Name("onwarning")]
		public HtmlEventHandler OnWarning;

		public extern void Pause();

		public extern void RemoveEventListener(MediaRecorderEvents type, Action listener);

		public extern void RemoveEventListener(MediaRecorderEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MediaRecorderEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MediaRecorderEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MediaRecorderEvents type, HtmlEventHandlerWithTarget<MediaRecorder> listener);

		public extern void RemoveEventListener(MediaRecorderEvents type, HtmlEventHandlerWithTarget<MediaRecorder> listener, bool capture);

		public extern void RemoveEventListener(MediaRecorderEvents type, IEventListener listener);

		public extern void RemoveEventListener(MediaRecorderEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaRecorder> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaRecorder> listener, bool capture);

		public extern void RequestData();

		public extern void Resume();

		public extern void Start();

		public extern void Start(int timeSlice);

		public readonly RecordingState State;

		public extern void Stop();

		public readonly MediaStream Stream;
	}
}
