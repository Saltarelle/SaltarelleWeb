// WaveShaperNode.cs
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
    /// WaveShaperNode is an AudioNode processor implementing non-linear distortion effects.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#WaveShaperNode</reference>
    [IgnoreNamespace, Imported]
    public class WaveShaperNode : AudioNode
    {
        private WaveShaperNode()
        {
        }

        /// <summary>
        /// The shaping curve used for the waveshaping effect. The input signal is nominally within 
        /// the range -1 -> +1. Each input sample within this range will index into the shaping 
        /// curve with a signal level of zero corresponding to the center value of the curve array. 
        /// Any sample value less than -1 will correspond to the first value in the curve array. 
        /// Any sample value less greater than +1 will correspond to the last value in the curve array.
        /// </summary>
        [IntrinsicProperty]
        public Float32Array Curve { get; set; }
    }
}
