﻿// BiquadFilterNode.cs
// SaltarelleWeb/Html/Media/Audio
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Timothy Fries - drysart@gmail.com

using System;
using System.Collections.Generic;
using System.Html.Media.Graphics.WebGL;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html.Media.Audio
{
    /// <summary>
    /// BiquadFilterNode is an AudioNode processor implementing very common low-order filters.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#BiquadFilterNode</reference>
    [IgnoreNamespace, Imported]
    public class BiquadFilterNode : AudioNode
    {
        private BiquadFilterNode()
        {
        }

        /// <summary>
        /// The filter type to be implemented by this node.
        /// </summary>
        public BiquadFilterType Type { get; private set; }

        /// <summary>
        /// The frequency setting for the selected filter type, in hertz.
        /// </summary>
        public AudioParam Frequency { get; private set; }

        /// <summary>
        /// The detune setting for the selected filter type, in cents.
        /// </summary>
        public AudioParam Detune { get; private set; }

        /// <summary>
        /// The Q setting for the selected filter type.
        /// </summary>
        [ScriptName("Q")]
        public AudioParam Q { get; private set; }

        /// <summary>
        /// The gain setting for the selected filter type, in decibels.
        /// </summary>
        public AudioParam Gain { get; private set; }

        /// <summary>
        /// Given the current filter parameter settings, calculates the frequency response 
        /// for the specified frequencies.
        /// </summary>
        /// <param name="frequencyHz">The frequencyHz parameter specifies an array of frequencies 
        /// at which the response values will be calculated.</param>
        /// <param name="magResponse">The magResponse parameter specifies an output array receiving
        /// the linear magnitude response values.</param>
        /// <param name="phaseResponse">The phaseResponse parameter specifies an output array receiving
        /// the phase response values in radians.</param>
        public void GetFrequencyResponse(Float32Array frequencyHz, Float32Array magResponse, Float32Array phaseResponse)
        {
        }
    }
}
