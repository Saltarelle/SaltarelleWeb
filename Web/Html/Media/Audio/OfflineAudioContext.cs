// OfflineAudioContext.cs
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
    /// OfflineAudioContext is a particular type of AudioContext for rendering/mixing-down (potentially) 
    /// faster than real-time. It does not render to the audio hardware, but instead renders as quickly 
    /// as possible, calling a render callback function upon completion with the result provided as an AudioBuffer.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#OfflineAudioContext-section</reference>
    [IgnoreNamespace, Imported]
    public class OfflineAudioContext : AudioContext
    {
        /// <summary>
        /// Creates a new OfflineAudioContext renderer.
        /// </summary>
        /// <param name="numberOfChannels">The numberOfChannels parameter specifies the target number
        /// of channels to render to.</param>
        /// <param name="length">The length parameter specifies the number of samples to render.</param>
        /// <param name="sampleRate">The sampleRate parameter specifies the sample rate to render with.</param>
        public OfflineAudioContext(uint numberOfChannels, uint length, float sampleRate)
        {
        }

        /// <summary>
        /// Renders the AudioNodes connected to this context.  The OnComplete callback will be called when
        /// the rendering has completed.
        /// </summary>
        public void StartRendering()
        {
        }

        /// <summary>
        /// The callback to call when the rendering operation has completed.
        /// </summary>
        [IntrinsicProperty]
        [ScriptName("oncomplete")]
        public Action<AudioBuffer> OnComplete { get; set; }
    }
}
