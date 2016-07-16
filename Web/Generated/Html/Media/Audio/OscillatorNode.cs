using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class OscillatorNode : AudioNode {
		internal OscillatorNode() {
		}

		public void AddEventListener(OscillatorNodeEvents type, Action listener) {
		}

		public void AddEventListener(OscillatorNodeEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(OscillatorNodeEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(OscillatorNodeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(OscillatorNodeEvents type, HtmlEventHandlerWithTarget<OscillatorNode> listener) {
		}

		public void AddEventListener(OscillatorNodeEvents type, HtmlEventHandlerWithTarget<OscillatorNode> listener, bool capture) {
		}

		public void AddEventListener(OscillatorNodeEvents type, IEventListener listener) {
		}

		public void AddEventListener(OscillatorNodeEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener, bool capture) {
		}

		public const ushort CUSTOM = 4;

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

		public void NoteOff(double when) {
		}

		public void NoteOn(double when) {
		}

		[IntrinsicProperty, ScriptName("onended")]
		public HtmlEventHandler OnEnded {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(OscillatorNodeEvents type, Action listener) {
		}

		public void RemoveEventListener(OscillatorNodeEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(OscillatorNodeEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(OscillatorNodeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(OscillatorNodeEvents type, HtmlEventHandlerWithTarget<OscillatorNode> listener) {
		}

		public void RemoveEventListener(OscillatorNodeEvents type, HtmlEventHandlerWithTarget<OscillatorNode> listener, bool capture) {
		}

		public void RemoveEventListener(OscillatorNodeEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(OscillatorNodeEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener, bool capture) {
		}

		public const ushort SAWTOOTH = 2;

		public void SetPeriodicWave(PeriodicWave periodicWave) {
		}

		public const ushort SINE = 0;

		public const ushort SQUARE = 1;

		public void Start() {
		}

		public void Start(double when) {
		}

		public void Stop() {
		}

		public void Stop(double when) {
		}

		public const ushort TRIANGLE = 3;

		[IntrinsicProperty]
		public OscillatorType Type {
			get {
				return default(OscillatorType);
			}
			set {
			}
		}
	}
}
