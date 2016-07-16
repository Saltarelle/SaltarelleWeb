namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class OscillatorNode : AudioNode
	{
		internal extern OscillatorNode();

		public extern void AddEventListener(OscillatorNodeEvents type, Action listener);

		public extern void AddEventListener(OscillatorNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(OscillatorNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(OscillatorNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(OscillatorNodeEvents type, HtmlEventHandlerWithTarget<OscillatorNode> listener);

		public extern void AddEventListener(OscillatorNodeEvents type, HtmlEventHandlerWithTarget<OscillatorNode> listener, bool capture);

		public extern void AddEventListener(OscillatorNodeEvents type, IEventListener listener);

		public extern void AddEventListener(OscillatorNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener, bool capture);

		public const ushort CUSTOM = 4;

		[FieldProperty]
		public extern AudioParam Detune
		{
			get;
		}

		[FieldProperty]
		public extern AudioParam Frequency
		{
			get;
		}

		public extern void NoteOff(double when);

		public extern void NoteOn(double when);

		[FieldProperty, Name("onended")]
		public extern HtmlEventHandler OnEnded
		{
			get;
			set;
		}

		public extern void RemoveEventListener(OscillatorNodeEvents type, Action listener);

		public extern void RemoveEventListener(OscillatorNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(OscillatorNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(OscillatorNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(OscillatorNodeEvents type, HtmlEventHandlerWithTarget<OscillatorNode> listener);

		public extern void RemoveEventListener(OscillatorNodeEvents type, HtmlEventHandlerWithTarget<OscillatorNode> listener, bool capture);

		public extern void RemoveEventListener(OscillatorNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(OscillatorNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener, bool capture);

		public const ushort SAWTOOTH = 2;

		public extern void SetPeriodicWave(PeriodicWave periodicWave);

		public const ushort SINE = 0;

		public const ushort SQUARE = 1;

		public extern void Start();

		public extern void Start(double when);

		public extern void Stop();

		public extern void Stop(double when);

		public const ushort TRIANGLE = 3;

		[FieldProperty]
		public extern OscillatorType Type
		{
			get;
			set;
		}
	}
}
