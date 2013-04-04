// AudioNode.cs
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
    /// AudioNode represents audio sources, the audio destination, and intermediate processing modules.
    /// </summary>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#AudioNode-section</reference>
    [IgnoreNamespace, Imported]
    public abstract class AudioNode
    {
        protected AudioNode()
        {
        }

        /// <summary>
        /// Connects the AudioNode to another AudioNode.
        /// </summary>
        /// <param name="destination">The destination parameter is the AudioNode to connect to.</param>
        public void Connect(AudioNode destination)
        {
        }

        /// <summary>
        /// Connects the AudioNode to another AudioNode.
        /// </summary>
        /// <param name="destination">The destination parameter is the AudioNode to connect to.</param>
        /// <param name="output">The output parameter is an index describing which output of the AudioNode 
        /// from which to connect. An out-of-bound value throws an exception.</param>
        public void Connect(AudioNode destination, uint output)
        {
        }

        /// <summary>
        /// Connects the AudioNode to another AudioNode.
        /// </summary>
        /// <param name="destination">The destination parameter is the AudioNode to connect to.</param>
        /// <param name="output">The output parameter is an index describing which output of the AudioNode 
        /// from which to connect. An out-of-bound value throws an exception.</param>
        /// <param name="input">The input parameter is an index describing which input of the destination
        /// AudioNode to connect to. An out-of-bound value throws an exception.</param>
        public void Connect(AudioNode destination, uint output, uint input)
        {
        }

        /// <summary>
        /// Connects the AudioNode to an AudioParam, controlling the parameter value with an audio-rate signal.
        /// </summary>
        /// <param name="destination">The destination parameter is the AudioParam to connect to.</param>
        public void Connect(AudioParam destination)
        {
        }

        /// <summary>
        /// Connects the AudioNode to an AudioParam, controlling the parameter value with an audio-rate signal.
        /// </summary>
        /// <param name="destination">The destination parameter is the AudioParam to connect to.</param>
        /// <param name="output">The output parameter is an index describing which output of the AudioNode
        /// from which to connect. An out-of-bound value throws an exception.</param>
        public void Connect(AudioParam destination, uint output)
        {
        }

        /// <summary>
        /// Disconnects an AudioNode's output.
        /// </summary>
        public void Disconnect()
        {
        }

        /// <summary>
        /// Disconnects an AudioNode's output.
        /// </summary>
        /// <param name="output">The output parameter is an index describing which output of the 
        /// AudioNode to disconnect. An out-of-bound value throws an exception.</param>
        public void Disconnect(uint output)
        {
        }

        /// <summary>
        /// The AudioContext which owns this AudioNode.
        /// </summary>
        [IntrinsicProperty]
        public AudioContext Context { get; private set; }

        /// <summary>
        /// The number of inputs feeding into the AudioNode. This will be 0 for an AudioSourceNode.
        /// </summary>
        [IntrinsicProperty]
        public uint NumberOfInputs { get; private set; }

        /// <summary>
        /// The number of outputs coming out of the AudioNode. This will be 0 for an AudioDestinationNode.
        /// </summary>
        [IntrinsicProperty]
        public uint NumberOfOutputs { get; private set; }
    }
}
