// GainNode.cs
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
    /// This interface is an AudioNode with a single input and single output which multiplies 
    /// the input audio signal by the (possibly time-varying) gain attribute, copying the 
    /// result to the output.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#GainNode</reference>
    [IgnoreNamespace, Imported]
    public class GainNode : AudioNode
    {
        private GainNode()
        {
        }

        /// <summary>
        /// Represents the amount of gain to apply. Its default value is 1 (no gain change). 
        /// The nominal minValue is 0, but may be set negative for phase inversion. The nominal 
        /// maxValue is 1, but higher values are allowed (no exception thrown).
        /// This parameter is a-rate.
        /// </summary>
        [IntrinsicProperty]
        public AudioParam Gain { get; private set; }
    }
}
