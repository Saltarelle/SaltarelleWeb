// DelayNode.cs
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
    /// This interface is an AudioNode with a single input and single output which delays 
    /// the incoming audio signal by a certain amount.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#DelayNode</reference>
    [IgnoreNamespace, Imported]
    public class DelayNode : AudioNode
    {
        private DelayNode()
        {
        }

        /// <summary>
        /// An AudioParam object representing the amount of delay (in seconds) to apply. 
        /// The default value (delayTime.value) is 0 (no delay). The minimum value is 0 
        /// and the maximum value is determined by the maxDelayTime argument to the 
        /// AudioContext method createDelay. This parameter is k-rate.
        /// </summary>
        [IntrinsicProperty]
        public AudioParam DelayTime { get; private set; }
    }
}
