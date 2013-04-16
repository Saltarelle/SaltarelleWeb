// AudioBufferSourceNode.cs
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
    /// This interface represents an audio source from an in-memory audio 
    /// asset in an AudioBuffer.
    /// </summary>
    [IgnoreNamespace, Imported]
    public class AudioBufferSourceNode : AudioSourceNode
    {
        private AudioBufferSourceNode()
        {
        }

        /// <summary>
        /// The playback state, initialized to AudioBufferSourceNodePlaybackState.UnscheduledState.
        /// </summary>
        [IntrinsicProperty]
        public AudioBufferSourceNodePlaybackState PlaybackState { get; private set; }

        /// <summary>
        /// Represents the audio asset to be played.
        /// </summary>
        [IntrinsicProperty]
        public AudioBuffer Buffer { get; set; }

        /// <summary>
        /// The speed at which to render the audio stream. The default playbackRate.value 
        /// is 1. This parameter is a-rate.
        /// </summary>
        [IntrinsicProperty]
        public AudioParam PlaybackRate { get; set; }

        /// <summary>
        /// Indicates if the audio data should play in a loop. The default value is false.
        /// </summary>
        [IntrinsicProperty]
        public bool Loop { get; set; }

        /// <summary>
        /// An optional value in seconds where looping should begin if the loop attribute 
        /// is true. Its default value is 0, and it may usefully be set to any value 
        /// between 0 and the duration of the buffer.
        /// </summary>
        [IntrinsicProperty]
        public double LoopStart { get; set; }

        /// <summary>
        /// An optional value in seconds where looping should end if the loop attribute is 
        /// true. Its default value is 0, and it may usefully be set to any value between 
        /// 0 and the duration of the buffer.
        /// </summary>
        [IntrinsicProperty]
        public double LoopEnd { get; set; }

        /// <summary>
        /// Schedules a sound to playback at an exact time.
        /// </summary>
        /// <param name="when">The when parameter describes at what time (in seconds) the sound 
        /// should start playing. It is in the same time coordinate system as AudioContext.currentTime. 
        /// If 0 is passed in for this value or if the value is less than currentTime, then the 
        /// sound will start playing immediately. start may only be called one time and must be 
        /// called before stop is called or an exception will be thrown.</param>
        public void Start(double when)
        {
        }

        /// <summary>
        /// Schedules a sound to playback at an exact time.
        /// </summary>
        /// <param name="when">The when parameter describes at what time (in seconds) the sound 
        /// should start playing. It is in the same time coordinate system as AudioContext.currentTime. 
        /// If 0 is passed in for this value or if the value is less than currentTime, then the 
        /// sound will start playing immediately. start may only be called one time and must be 
        /// called before stop is called or an exception will be thrown.</param>
        /// <param name="offset">The offset parameter describes the offset time in the buffer (in 
        /// seconds) where playback will begin.</param>
        public void Start(double when, double offset)
        {
        }

        /// <summary>
        /// Schedules a sound to playback at an exact time.
        /// </summary>
        /// <param name="when">The when parameter describes at what time (in seconds) the sound 
        /// should start playing. It is in the same time coordinate system as AudioContext.currentTime. 
        /// If 0 is passed in for this value or if the value is less than currentTime, then the 
        /// sound will start playing immediately. start may only be called one time and must be 
        /// called before stop is called or an exception will be thrown.</param>
        /// <param name="offset">The offset parameter describes the offset time in the buffer (in 
        /// seconds) where playback will begin.</param>
        /// <param name="duration">The duration parameter describes the duration of the portion 
        /// (in seconds) to be played.</param>
        public void Start(double when, double offset, double duration)
        {
        }

        /// <summary>
        /// Schedules a sound to stop playback at an exact time.
        /// </summary>
        /// <param name="when">The when parameter describes at what time (in seconds) the sound 
        /// should stop playing. It is in the same time coordinate system as AudioContext.currentTime. 
        /// If 0 is passed in for this value or if the value is less than currentTime, then the sound 
        /// will stop playing immediately. stop must only be called one time and only after a call 
        /// to start or stop, or an exception will be thrown.</param>
        public void Stop(double when)
        {
        }
    }
}
