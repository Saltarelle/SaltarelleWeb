// OscillatorNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	/// <summary>
	/// OscillatorNode represents an audio source generating a periodic waveform.
	/// </summary>
	/// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#OscillatorNode</reference>
	[IgnoreNamespace, Imported]
	public class OscillatorNode {
		private OscillatorNode() {
		}

		/// <summary>
		/// A detuning value (in Cents) which will offset the frequency by the given amount. 
		/// This parameter is a-rate.
		/// </summary>
		[IntrinsicProperty]
		public AudioParam Detune { get; private set; }

		/// <summary>
		/// The frequency (in Hertz) of the periodic waveform. This parameter is a-rate.
		/// </summary>
		[IntrinsicProperty]
		public AudioParam Frequency { get; private set; }

		/// <summary>
		/// defined as in AudioBufferSourceNode.
		/// </summary>
		[IntrinsicProperty]
		public OscillatorNodePlaybackState PlaybackState { get; private set; }

		/// <summary>
		/// Sets an arbitrary custom periodic waveform given a WaveTable.
		/// </summary>
		/// <param name="waveTable">The waveTable parameter specifies the wave
		/// table to use to specify a custom waveform.</param>
		public void SetWaveTable(WaveTable waveTable) {
		}

		/// <summary>
		/// defined as in AudioBufferSourceNode.
		/// </summary>
		/// <param name="when"></param>
		public void Start(double when) {
		}

		/// <summary>
		/// defined as in AudioBufferSourceNode.
		/// </summary>
		/// <param name="when"></param>
		public void Stop(double when) {
		}

		/// <summary>
		/// The shape of the periodic waveform. It may directly be set to any of the enumeration values 
		/// except for OscillatorType.Custom. The SetWaveTable() method can be used to set a custom 
		/// waveform, which results in this attribute being set to OscillatorType.Custom. The default 
		/// value is OscillatorType.Sine.
		/// </summary>
		[IntrinsicProperty]
		public OscillatorType Type { get; set; }
	}
}