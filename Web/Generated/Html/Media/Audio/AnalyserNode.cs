// AnalyserNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	/// <summary>
	/// This interface represents a node which is able to provide real-time frequency and 
	/// time-domain analysis information. The audio stream will be passed un-processed 
	/// from input to output.
	/// </summary>
	/// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#AnalyserNode</reference>
	[IgnoreNamespace, Imported]
	public class AnalyserNode : AudioNode {
		private AnalyserNode() {
		}

		/// <summary>
		/// The size of the FFT used for frequency-domain analysis. This must be a power of two.
		/// </summary>
		[IntrinsicProperty]
		public uint FftSize { get; set; }

		/// <summary>
		/// Half the FFT size.
		/// </summary>
		[IntrinsicProperty]
		public uint FrequencyBinCount { get; private set; }

		/// <summary>
		/// Copies the current frequency data into the passed unsigned byte array. If the 
		/// array has fewer elements than the frequencyBinCount, the excess elements 
		/// will be dropped.
		/// </summary>
		/// <param name="array">The array parameter is where frequency-domain analysis
		/// data will be copied.</param>
		public void GetByteFrequencyData(Uint8Array array) {
		}

		/// <summary>
		/// Copies the current time-domain (waveform) data into the passed unsigned byte 
		/// array. If the array has fewer elements than the frequencyBinCount, the excess 
		/// elements will be dropped.
		/// </summary>
		/// <param name="array">The array parameter is where time-domain analysis data 
		/// will be copied.</param>
		public void GetByteTimeDomainData(Uint8Array array) {
		}

		/// <summary>
		/// Copies the current frequency data into the passed floating-point array. If the 
		/// array has fewer elements than the frequencyBinCount, the excess elements 
		/// will be dropped.
		/// </summary>
		/// <param name="array">The array parameter is where frequency-domain analysis 
		/// data will be copied.</param>
		public void GetFloatFrequencyData(Float32Array array) {
		}

		/// <summary>
		/// The maximum power value in the scaling range for the FFT analysis data 
		/// for conversion to unsigned byte values.
		/// </summary>
		[IntrinsicProperty]
		public float MaxDecibels { get; set; }

		/// <summary>
		/// The minimum power value in the scaling range for the FFT analysis data 
		/// for conversion to unsigned byte values.
		/// </summary>
		[IntrinsicProperty]
		public float MinDecibels { get; set; }

		/// <summary>
		/// A value from 0 -> 1 where 0 represents no time averaging with the last 
		/// analysis frame.
		/// </summary>
		[IntrinsicProperty]
		public float SmoothingTimeConstant { get; set; }
	}
}