// AudioProcessingEvent.cs
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
    /// This interface is a type of Event which is passed to the onaudioprocess event handler 
    /// used by ScriptProcessorNode.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#AudioProcessingEvent</reference>
    [IgnoreNamespace, Imported]
    public class AudioProcessingEvent
    {
        private AudioProcessingEvent()
        {
        }

        /// <summary>
        /// The ScriptProcessorNode associated with this processing event.
        /// </summary>
        [IntrinsicProperty]
        public ScriptProcessorNode Node { get; set; }

        /// <summary>
        /// The time when the audio will be played in the same time coordinate system as 
        /// AudioContext.currentTime. playbackTime allows for very tight synchronization between 
        /// processing directly in script with the other events in the context's rendering graph.
        /// </summary>
        [IntrinsicProperty]
        public double PlaybackTime { get; private set; }

        /// <summary>
        /// An AudioBuffer containing the input audio data. It will have a number of channels equal 
        /// to the numberOfInputChannels parameter of the createScriptProcessor() method. This 
        /// AudioBuffer is only valid while in the scope of the onaudioprocess function. Its values 
        /// will be meaningless outside of this scope.
        /// </summary>
        [IntrinsicProperty]
        public AudioBuffer InputBuffer { get; private set; }

        /// <summary>
        /// An AudioBuffer where the output audio data should be written. It will have a number of 
        /// channels equal to the numberOfOutputChannels parameter of the createScriptProcessor() 
        /// method. Script code within the scope of the onaudioprocess function is expected to 
        /// modify the Float32Array arrays representing channel data in this AudioBuffer. Any script 
        /// modifications to this AudioBuffer outside of this scope will not produce any audible effects.
        /// </summary>
        [IntrinsicProperty]
        public AudioBuffer OutputBuffer { get; private set; }
    }
}
