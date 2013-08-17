using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class OscillatorNode : AudioNode {
		internal OscillatorNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener, bool capture) {
		}

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

		[IntrinsicProperty, ScriptName("onended")]
		public HtmlEventHandler OnEnded {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OscillatorNode> listener, bool capture) {
		}

		public void SetPeriodicWave(PeriodicWave periodicWave) {
		}

		public void Start(double when) {
		}

		public void Stop(double when) {
		}

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
