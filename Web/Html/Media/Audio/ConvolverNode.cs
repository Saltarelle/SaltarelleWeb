// ConvolverNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	/// <summary>
	/// This interface represents a processing node which applies a linear 
	/// convolution effect given an impulse response.
	/// </summary>
	/// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#ConvolverNode</reference>
	[IgnoreNamespace, Imported]
	public class ConvolverNode : AudioNode {
		private ConvolverNode() {
		}

		/// <summary>
		/// A mono, stereo, or 4-channel AudioBuffer containing the (possibly multi-channel) 
		/// impulse response used by the ConvolverNode. At the time when this attribute is 
		/// set, the buffer and the state of the normalize attribute will be used to configure 
		/// the ConvolverNode with this impulse response having the given normalization.
		/// </summary>
		[IntrinsicProperty]
		public AudioBuffer Buffer { get; set; }

		/// <summary>
		/// Controls whether the impulse response from the buffer will be scaled by an equal-power 
		/// normalization when the buffer atttribute is set. Its default value is true in order 
		/// to achieve a more uniform output level from the convolver when loaded with diverse 
		/// impulse responses. If normalize is set to false, then the convolution will be 
		/// rendered with no pre-processing/scaling of the impulse response. Changes to this 
		/// value do not take effect until the next time the buffer attribute is set.
		/// </summary>
		[IntrinsicProperty]
		public bool Normalize { get; set; }
	}
}