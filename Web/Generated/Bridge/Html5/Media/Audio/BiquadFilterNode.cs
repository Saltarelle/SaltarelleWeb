using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class BiquadFilterNode : AudioNode
	{
		internal BiquadFilterNode()
		{
		}

		public void AddEventListener(BiquadFilterNodeEvents type, Action listener)
		{
		}

		public void AddEventListener(BiquadFilterNodeEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(BiquadFilterNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(BiquadFilterNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(BiquadFilterNodeEvents type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener)
		{
		}

		public void AddEventListener(BiquadFilterNodeEvents type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener, bool capture)
		{
		}

		public void AddEventListener(BiquadFilterNodeEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(BiquadFilterNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener, bool capture)
		{
		}

		public const ushort ALLPASS = 7;

		public const ushort BANDPASS = 2;

		[FieldProperty]
		public AudioParam Detune
		{
			get {
				return default(AudioParam);
			}
		}

		[FieldProperty]
		public AudioParam Frequency
		{
			get {
				return default(AudioParam);
			}
		}

		[FieldProperty]
		public AudioParam Gain
		{
			get {
				return default(AudioParam);
			}
		}

		public void GetFrequencyResponse(Float32Array frequencyHz, Float32Array magResponse, Float32Array phaseResponse)
		{
		}

		public const ushort HIGHPASS = 1;

		public const ushort HIGHSHELF = 4;

		public const ushort LOWPASS = 0;

		public const ushort LOWSHELF = 3;

		public const ushort NOTCH = 6;

		public const ushort PEAKING = 5;

		[FieldProperty, Name("Q")]
		public AudioParam Q
		{
			get {
				return default(AudioParam);
			}
		}

		public void RemoveEventListener(BiquadFilterNodeEvents type, Action listener)
		{
		}

		public void RemoveEventListener(BiquadFilterNodeEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(BiquadFilterNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(BiquadFilterNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(BiquadFilterNodeEvents type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener)
		{
		}

		public void RemoveEventListener(BiquadFilterNodeEvents type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener, bool capture)
		{
		}

		public void RemoveEventListener(BiquadFilterNodeEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(BiquadFilterNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener, bool capture)
		{
		}

		[FieldProperty]
		public BiquadFilterType Type
		{
			get {
				return default(BiquadFilterType);
			}
			set {
			}
		}
	}
}
