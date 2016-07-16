namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioBufferSourceNode : AudioNode
	{
		internal AudioBufferSourceNode()
		{
		}

		public void AddEventListener(AudioBufferSourceNodeEvents type, Action listener)
		{
		}

		public void AddEventListener(AudioBufferSourceNodeEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener)
		{
		}

		public void AddEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener, bool capture)
		{
		}

		public void AddEventListener(AudioBufferSourceNodeEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(AudioBufferSourceNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener, bool capture)
		{
		}

		[FieldProperty]
		public AudioBuffer Buffer
		{
			get {
				return default(AudioBuffer);
			}
			set {
			}
		}

		[FieldProperty]
		public bool Loop
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public double LoopEnd
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public double LoopStart
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void NoteGrainOn(double when, double grainOffset, double grainDuration)
		{
		}

		public void NoteOff(double when)
		{
		}

		public void NoteOn(double when)
		{
		}

		[FieldProperty, Name("onended")]
		public HtmlEventHandler OnEnded
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty]
		public AudioParam PlaybackRate
		{
			get {
				return default(AudioParam);
			}
		}

		public void RemoveEventListener(AudioBufferSourceNodeEvents type, Action listener)
		{
		}

		public void RemoveEventListener(AudioBufferSourceNodeEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener)
		{
		}

		public void RemoveEventListener(AudioBufferSourceNodeEvents type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioBufferSourceNodeEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(AudioBufferSourceNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioBufferSourceNode> listener, bool capture)
		{
		}

		public void Start()
		{
		}

		public void Start(double when)
		{
		}

		public void Start(double when, double grainOffset)
		{
		}

		public void Start(double when, double grainOffset, double grainDuration)
		{
		}

		public void Stop()
		{
		}

		public void Stop(double when)
		{
		}
	}
}
