using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External]
	public partial class BiquadFilterNode : AudioNode
	{
		internal extern BiquadFilterNode();

		public extern void AddEventListener(BiquadFilterNodeEvents type, Action listener);

		public extern void AddEventListener(BiquadFilterNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(BiquadFilterNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(BiquadFilterNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(BiquadFilterNodeEvents type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener);

		public extern void AddEventListener(BiquadFilterNodeEvents type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener, bool capture);

		public extern void AddEventListener(BiquadFilterNodeEvents type, IEventListener listener);

		public extern void AddEventListener(BiquadFilterNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener, bool capture);

		public const ushort ALLPASS = 7;

		public const ushort BANDPASS = 2;

		public readonly AudioParam Detune;

		public readonly AudioParam Frequency;

		public readonly AudioParam Gain;

		public extern void GetFrequencyResponse(Float32Array frequencyHz, Float32Array magResponse, Float32Array phaseResponse);

		public const ushort HIGHPASS = 1;

		public const ushort HIGHSHELF = 4;

		public const ushort LOWPASS = 0;

		public const ushort LOWSHELF = 3;

		public const ushort NOTCH = 6;

		public const ushort PEAKING = 5;

		[Name("Q")]
		public readonly AudioParam Q;

		public extern void RemoveEventListener(BiquadFilterNodeEvents type, Action listener);

		public extern void RemoveEventListener(BiquadFilterNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(BiquadFilterNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(BiquadFilterNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(BiquadFilterNodeEvents type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener);

		public extern void RemoveEventListener(BiquadFilterNodeEvents type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener, bool capture);

		public extern void RemoveEventListener(BiquadFilterNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(BiquadFilterNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener, bool capture);

		public BiquadFilterType Type;
	}
}
