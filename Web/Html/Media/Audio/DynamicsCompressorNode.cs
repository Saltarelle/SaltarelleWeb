// DynamicsCompressorNode.cs
// SaltarelleWeb/Html/Media/Audio
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Timothy Fries - drysart@gmail.com


using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html.Media.Audio
{
    /// <summary>
    /// DynamicsCompressorNode is an AudioNode processor implementing a dynamics compression effect.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#DynamicsCompressorNode</reference>
    [IgnoreNamespace, Imported]
    public class DynamicsCompressorNode : AudioNode
    {
        private DynamicsCompressorNode()
        {
        }

        /// <summary>
        /// The decibel value above which the compression will start taking effect. Its default 
        /// value is -24, with a nominal range of -100 to 0.  This parameter is k-rate.
        /// </summary>
        [IntrinsicProperty]
        public AudioParam Threshold { get; private set; }

        /// <summary>
        /// A decibel value representing the range above the threshold where the curve smoothly 
        /// transitions to the "ratio" portion. Its default value is 30, with a nominal range 
        /// of 0 to 40.  This parameter is k-rate.
        /// </summary>
        [IntrinsicProperty]
        public AudioParam Knee { get; private set; }

        /// <summary>
        /// The amount of dB change in input for a 1 dB change in output. Its default value is 
        /// 12, with a nominal range of 1 to 20.  This parameter is k-rate.
        /// </summary>
        [IntrinsicProperty]
        public AudioParam Ratio { get; private set; }

        /// <summary>
        /// A read-only decibel value for metering purposes, representing the current amount of 
        /// gain reduction that the compressor is applying to the signal. If fed no signal the 
        /// value will be 0 (no gain reduction). The nominal range is -20 to 0. This
        /// parameter is k-rate.
        /// </summary>
        [IntrinsicProperty]
        public AudioParam Reduction { get; private set; }

        /// <summary>
        /// The amount of time (in seconds) to reduce the gain by 10dB. Its default value is 
        /// 0.003, with a nominal range of 0 to 1.  This parameter is k-rate.
        /// </summary>
        [IntrinsicProperty]
        public AudioParam Attack { get; private set; }

        /// <summary>
        /// The amount of time (in seconds) to increase the gain by 10dB. Its default value 
        /// is 0.250, with a nominal range of 0 to 1.  This parameter is k-rate.
        /// </summary>
        [IntrinsicProperty]
        public AudioParam Release { get; private set; }
    }
}
