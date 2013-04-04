// ScriptProcessorNode.cs
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
    /// This interface is an AudioNode which can generate, process, or analyse audio 
    /// directly using a supplied callback.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#ScriptProcessorNode</reference>
    [IgnoreNamespace, Imported]
    public class ScriptProcessorNode : AudioNode
    {
        private ScriptProcessorNode()
        {
        }

        /// <summary>
        /// An event listener which is called periodically for audio processing. An event of type 
        /// AudioProcessingEvent will be passed to the event handler.
        /// </summary>
        [IntrinsicProperty]
        [ScriptName("onaudioprocess")]
        public Action<AudioProcessingEvent> OnAudioProcess { get; set; }

        /// <summary>
        /// The size of the buffer (in sample-frames) which needs to be processed each time 
        /// onprocessaudio is called. Legal values are (256, 512, 1024, 2048, 4096, 8192, 16384).
        /// </summary>
        [IntrinsicProperty]
        public long BufferSize { get; private set; }
    }
}
