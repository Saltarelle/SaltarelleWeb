using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class BiquadFilterNode : AudioNode {
		internal BiquadFilterNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener, bool capture) {
		}

		public const ushort ALLPASS = 7;

		public const ushort BANDPASS = 2;

		[IntrinsicProperty]
		public AudioParam Detune {
			get {
				return default(AudioParam);
			}
		}

		[IntrinsicProperty]
		public AudioParam Frequency {
			get {
				return default(AudioParam);
			}
		}

		[IntrinsicProperty]
		public AudioParam Gain {
			get {
				return default(AudioParam);
			}
		}

		public void GetFrequencyResponse(Float32Array frequencyHz, Float32Array magResponse, Float32Array phaseResponse) {
		}

		public const ushort HIGHPASS = 1;

		public const ushort HIGHSHELF = 4;

		public const ushort LOWPASS = 0;

		public const ushort LOWSHELF = 3;

		public const ushort NOTCH = 6;

		public const ushort PEAKING = 5;

		[IntrinsicProperty, ScriptName("Q")]
		public AudioParam Q {
			get {
				return default(AudioParam);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BiquadFilterNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public BiquadFilterType Type {
			get {
				return default(BiquadFilterType);
			}
			set {
			}
		}
	}
}
