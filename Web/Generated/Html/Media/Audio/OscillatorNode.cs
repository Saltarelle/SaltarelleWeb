﻿using System.Runtime.CompilerServices;

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