// AudioDestinationNode.cs
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
    /// AudioDestinationNode is an AudioNode representing the final audio destination and is 
    /// what the user will ultimately hear. It can be considered as an audio output device which 
    /// is connected to speakers. All rendered audio to be heard will be routed to this node, 
    /// a "terminal" node in the AudioContext's routing graph. There is only a single 
    /// AudioDestinationNode per AudioContext, provided through the destination attribute 
    /// of AudioContext.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#AudioDestinationNode</reference>
    [IgnoreNamespace, Imported]
    public class AudioDestinationNode : AudioNode
    {
        private AudioDestinationNode()
        {
        }

        /// <summary>
        /// The maximum number of channels that the numberOfChannels attribute can be set to. 
        /// An AudioDestinationNode representing the audio hardware end-point (the normal case) can 
        /// potentially output more than 2 channels of audio if the audio hardware is multi-channel. 
        /// maxNumberOfChannels is the maximum number of channels that this hardware is capable of 
        /// supporting. If this value is 0, then this indicates that maxNumberOfChannels may not be 
        /// changed. This will be the case for an AudioDestinationNode in an OfflineAudioContext.
        /// </summary>
        [IntrinsicProperty]
        public ulong MaxNumberOfChannels { get; private set; }

        /// <summary>
        /// The number of channels of the destination's input. This value will default to 2, and may 
        /// be set to any non-zero value less than or equal to maxNumberOfChannels. An exception will 
        /// be thrown if this value is not within the valid range. Giving a concrete example, if 
        /// the audio hardware supports 8-channel output, then we may set numberOfChannels 
        /// to 8, and render 8-channels of output.
        /// </summary>
        [IntrinsicProperty]
        ulong NumberOfChannels { get; set; }
    }
}
