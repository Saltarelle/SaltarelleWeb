namespace Bridge.Html5.Media.Recording
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern string MimeType
		{
			get;
		}

		[FieldProperty, Name("ondataavailable")]
		public extern HtmlEventHandler OnDataavailable
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

		[FieldProperty, Name("onstop")]
		public extern HtmlEventHandler OnStop
		{
			get;
			set;
		}

		[FieldProperty, Name("onwarning")]
		public extern HtmlEventHandler OnWarning
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern RecordingState State
		{
			get;
		}

		public extern void Stop();

		[FieldProperty]
		public extern MediaStream Stream
		{
			get;
		}
	}
}
