namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioBufferSourceNode : AudioNode
	{
		internal extern AudioBufferSourceNode();

		public extern void AddEventListener(AudioBufferSourceNodeEvents type, Action listener);

		public extern void AddEventListener(AudioBufferSourceNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener);

		public extern void AddEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener, bool capture);

		public extern void AddEventListener(AudioBufferSourceNodeEvents type, IEventListener listener);

		public extern void AddEventListener(AudioBufferSourceNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener, bool capture);

		[FieldProperty]
		public extern AudioBuffer Buffer
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Loop
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double LoopEnd
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double LoopStart
		{
			get;
			set;
		}

		public extern void NoteGrainOn(double when, double grainOffset, double grainDuration);

		public extern void NoteOff(double when);

		public extern void NoteOn(double when);

		[FieldProperty, Name("onended")]
		public extern HtmlEventHandler OnEnded
		{
			get;
			set;
		}

		[FieldProperty]
		public extern AudioParam PlaybackRate
		{
			get;
		}

		public extern void RemoveEventListener(AudioBufferSourceNodeEvents type, Action listener);

		public extern void RemoveEventListener(AudioBufferSourceNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener);

		public extern void RemoveEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener, bool capture);

		public extern void RemoveEventListener(AudioBufferSourceNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(AudioBufferSourceNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener, bool capture);

		public extern void Start();

		public extern void Start(double when);

		public extern void Start(double when, double grainOffset);

		public extern void Start(double when, double grainOffset, double grainDuration);

		public extern void Stop();

		public extern void Stop(double when);
	}
}
