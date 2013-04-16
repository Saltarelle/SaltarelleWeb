// AudioBuffer.cs
// SaltarelleWeb/Html/Media/Audio
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Timothy Fries - drysart@gmail.com

using System;
using System.Collections.Generic;
using System.Collections.TypedArrays;
using System.Html.Media.Graphics.WebGL;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html.Media.Audio
{
    /// <summary>
    /// This interface represents a memory-resident audio asset (for one-shot sounds and other 
    /// short audio clips). Its format is non-interleaved IEEE 32-bit linear PCM with a nominal 
    /// range of -1 -> +1. It can contain one or more channels.
    /// </summary>
    [IgnoreNamespace, Imported]
    public class AudioBuffer
    {
        private AudioBuffer()
        {
        }

        /// <summary>
        /// The sample-rate for the PCM audio data in samples per second.
        /// </summary>
        [IntrinsicProperty]
        public int SampleRate { get; private set; }

        /// <summary>
        /// Length of the PCM audio data in sample-frames.
        /// </summary>
        [IntrinsicProperty]
        public int Length { get; private set; }

        /// <summary>
        /// Duration of the PCM audio data in seconds.
        /// </summary>
        [IntrinsicProperty]
        public double Duration { get; private set; }

        /// <summary>
        /// The number of discrete audio channels.
        /// </summary>
        [IntrinsicProperty]
        public int NumberOfChannels { get; private set; }

        /// <summary>
        /// Returns the Float32Array representing the PCM audio data for the specific channel.
        /// </summary>
        /// <param name="channel">The channel parameter is an index representing the particular 
        /// channel to get data for. An index value of 0 represents the first channel. This 
        /// index value MUST be less than numberOfChannels or an exception will be thrown.</param>
        /// <returns>The Float32Array filled with the PCM audio data for the requested channel.</returns>
        public Float32Array GetChannelData(uint channel)
        {
            return null;
        }
    }
}
