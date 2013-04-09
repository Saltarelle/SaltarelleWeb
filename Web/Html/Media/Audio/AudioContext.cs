// AudioContext.cs
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
    /// This interface represents a set of AudioNode objects and their connections. It allows for
    /// arbitrary routing of signals to the AudioDestinationNode (what the user ultimately hears).
    /// Nodes are created from the context and are then connected together. In most use cases,
    /// only a single AudioContext is used per document.
    /// </summary>
    /// <remarks>Once created, an AudioContext will not be garbage collected. It will live
    /// until the document goes away.</remarks>
    /// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#AudioContext-section</reference>
    [IgnoreNamespace, Imported]
    public class AudioContext
    {
        /// <summary>
        /// Create a new AudioContext.
        /// </summary>
        [InlineCode("new (window.AudioContext || " +
                         "window.webkitAudioContext || " +
                         "window.mozAudioContext || " +
                         "window.msAudioContext || " +
                         "window.oAudioContext)()")]
        public AudioContext()
        {
        }

        /// <summary>
        /// An AudioDestinationNode with a single input representing the final destination for all
        /// audio (to be rendered to the audio hardware). All AudioNodes actively rendering audio will
        /// directly or indirectly connect to destination.
        /// </summary>
        [IntrinsicProperty]
        public AudioDestinationNode Destination { get; private set; }

        /// <summary>
        /// The sample rate (in sample-frames per second) at which the AudioContext handles audio. It 
        /// is assumed that all AudioNodes in the context run at this rate. In making this assumption, 
        /// sample-rate converters or "varispeed" processors are not supported in real-time processing.
        /// </summary>
        [IntrinsicProperty]
        public float SampleRate { get; private set; }

        /// <summary>
        /// This is a time in seconds which starts at zero when the context is created and increases in 
        /// real-time. All scheduled times are relative to it. This is not a "transport" time which can be 
        /// started, paused, and re-positioned. It is always moving forward. A GarageBand-like timeline 
        /// transport system can be very easily built on top of this (in JavaScript). This time corresponds 
        /// to an ever-increasing hardware timestamp.
        /// </summary>
        [IntrinsicProperty]
        public double CurrentTime { get; private set; }

        /// <summary>
        /// An AudioListener which is used for 3D spatialization.
        /// </summary>
        [IntrinsicProperty]
        public AudioListener Listener { get; private set; }

        /// <summary>
        /// The number of AudioBufferSourceNodes that are currently playing.
        /// </summary>
        [IntrinsicProperty]
        public uint ActiveSourceCount { get; private set; }

        /// <summary>
        /// Creates an AudioBuffer of the given size. The audio data in the buffer will be zero-initialized 
        /// (silent). An exception will be thrown if the numberOfChannels or sampleRate are out-of-bounds.
        /// </summary>
        /// <param name="numberOfChannels">The numberOfChannels parameter determines how many channels the 
        /// buffer will have. An implementation must support at least 32 channels.</param>
        /// <param name="length">The length parameter determines the size of the buffer in sample-frames.</param>
        /// <param name="sampleRate">The sampleRate parameter describes the sample-rate of the linear PCM audio 
        /// data in the buffer in sample-frames per second. An implementation must support sample-rates in at 
        /// least the range 22050 to 96000.</param>
        /// <returns>Returns the newly created AudioBuffer object.</returns>
        public AudioBuffer CreateBuffer(uint numberOfChannels, uint length, float sampleRate)
        {
            return null;
        }

        /// <summary>
        /// Creates an AudioBuffer given the audio file data contained in the ArrayBuffer. The ArrayBuffer can, 
        /// for example, be loaded from an XMLHttpRequest's response attribute after setting the responseType 
        /// to "arraybuffer". Audio file data can be in any of the formats supported by the audio element.
        /// </summary>
        /// <param name="buffer">The buffer parameter contains the audio file data (for example from a
        /// .wav file).</param>
        /// <param name="mixToMono">The mixToMono parameter determines if a mixdown to mono will be
        /// performed. Normally, this would not be set.</param>
        /// <returns>Returns the newly created AudioBuffer object.</returns>
        public AudioBuffer CreateBuffer(ArrayBuffer buffer, bool mixToMono)
        {
            return null;
        }

        /// <summary>
        /// Asynchronously decodes the audio file data contained in the ArrayBuffer. The ArrayBuffer can, 
        /// for example, be loaded from an XMLHttpRequest's response attribute after setting the responseType 
        /// to "arraybuffer". Audio file data can be in any of the formats supported by the audio element.
        /// </summary>
        /// <param name="audioData">audioData is an ArrayBuffer containing audio file data.</param>
        /// <param name="successCallback">successCallback is a callback function which will be invoked when the 
        /// decoding is finished. The single argument to this callback is an AudioBuffer representing the decoded 
        /// PCM audio data.</param>
        public void DecodeAudioData(ArrayBuffer audioData, Action<AudioBuffer> successCallback)
        {
        }

        /// <summary>
        /// Asynchronously decodes the audio file data contained in the ArrayBuffer. The ArrayBuffer can, 
        /// for example, be loaded from an XMLHttpRequest's response attribute after setting the responseType 
        /// to "arraybuffer". Audio file data can be in any of the formats supported by the audio element.
        /// </summary>
        /// <param name="audioData">audioData is an ArrayBuffer containing audio file data.</param>
        /// <param name="successCallback">successCallback is a callback function which will be invoked when the 
        /// decoding is finished. The single argument to this callback is an AudioBuffer representing the decoded 
        /// PCM audio data.</param>
        /// <param name="errorCallback">errorCallback is a callback function which will be invoked if there is 
        /// an error decoding the audio file data.</param>
        public void DecodeAudioData(ArrayBuffer audioData, Action<AudioBuffer> successCallback, Action errorCallback)
        {
        }

        /// <summary>
        /// Creates an AudioBufferSourceNode.
        /// </summary>
        /// <returns>The newly created AudioBufferSourceNode object.</returns>
        public AudioBufferSourceNode CreateBufferSource()
        {
            return null;
        }

        /// <summary>
        /// Creates a MediaElementAudioSourceNode given an HTMLMediaElement. As a consequence of calling this 
        /// method, audio playback from the HTMLMediaElement will be re-routed into the processing graph 
        /// of the AudioContext.
        /// </summary>
        /// <param name="mediaElement">mediaElement is an HTMLMediaElement (e.g. audio or video) whose
        /// audio playback should be rerouted into the AudioContext</param>
        /// <returns>The newly created MediaElementAudioSourceNode object.</returns>
        public MediaElementAudioSourceNode CreateMediaElementSource(System.Html.Element mediaElement)
        {
            return null;
        }

        /// <summary>
        /// Creates a MediaStreamAudioSourceNode given a MediaStream. As a consequence of calling this method, 
        /// audio playback from the MediaStream will be re-routed into the processing graph of the AudioContext.
        /// </summary>
        /// <param name="mediaStream">mediaStream is a MediaStream object whose audio playback should
        /// be rerouted into the AudioContext</param>
        /// <returns>The newly created MediaStreamAudioSourceNode object.</returns>
        public MediaStreamAudioSourceNode CreateMediaStreamSource(object mediaStream)
        {
            return null;
        }

        /// <summary>
        /// Creates a ScriptProcessorNode for direct audio processing using JavaScript. An exception will be 
        /// thrown if bufferSize or numberOfInputChannels or numberOfOutputChannels are outside the valid range.
        /// </summary>
        /// <param name="bufferSize">The bufferSize parameter determines the buffer size in units of sample-frames. 
        /// It must be one of the following values: 256, 512, 1024, 2048, 4096, 8192, 16384. This value controls 
        /// how frequently the onaudioprocess event handler is called and how many sample-frames need to be 
        /// processed each call. Lower values for bufferSize will result in a lower (better) latency. Higher 
        /// values will be necessary to avoid audio breakup and glitches. The value chosen must carefully balance 
        /// between latency and audio quality.</param>
        /// <returns>The newly created ScriptProcessorNode object.</returns>
        public ScriptProcessorNode CreateScriptProcessor(uint bufferSize)
        {
            return null;
        }

        /// <summary>
        /// Creates a ScriptProcessorNode for direct audio processing using JavaScript. An exception will be 
        /// thrown if bufferSize or numberOfInputChannels or numberOfOutputChannels are outside the valid range.
        /// </summary>
        /// <param name="bufferSize">The bufferSize parameter determines the buffer size in units of sample-frames. 
        /// It must be one of the following values: 256, 512, 1024, 2048, 4096, 8192, 16384. This value controls 
        /// how frequently the onaudioprocess event handler is called and how many sample-frames need to be 
        /// processed each call. Lower values for bufferSize will result in a lower (better) latency. Higher 
        /// values will be necessary to avoid audio breakup and glitches. The value chosen must carefully balance 
        /// between latency and audio quality.</param>
        /// <param name="numberOfInputChannels">The numberOfInputChannels parameter (defaults to 2) and determines 
        /// the number of channels for this node's input. Values of up to 32 must be supported.</param>
        /// <returns>The newly created ScriptProcessorNode object.</returns>
        public ScriptProcessorNode CreateScriptProcessor(uint bufferSize, uint numberOfInputChannels)
        {
            return null;
        }

        /// <summary>
        /// Creates a ScriptProcessorNode for direct audio processing using JavaScript. An exception will be 
        /// thrown if bufferSize or numberOfInputChannels or numberOfOutputChannels are outside the valid range.
        /// </summary>
        /// <param name="bufferSize">The bufferSize parameter determines the buffer size in units of sample-frames. 
        /// It must be one of the following values: 256, 512, 1024, 2048, 4096, 8192, 16384. This value controls 
        /// how frequently the onaudioprocess event handler is called and how many sample-frames need to be 
        /// processed each call. Lower values for bufferSize will result in a lower (better) latency. Higher 
        /// values will be necessary to avoid audio breakup and glitches. The value chosen must carefully balance 
        /// between latency and audio quality.</param>
        /// <param name="numberOfInputChannels">The numberOfInputChannels parameter (defaults to 2) and determines 
        /// the number of channels for this node's input. Values of up to 32 must be supported.</param>
        /// <param name="numberOfOutputChannels">The numberOfOutputChannels parameter (defaults to 2) and determines 
        /// the number of channels for this node's output. Values of up to 32 must be supported.</param>
        /// <returns>The newly created ScriptProcessorNode object.</returns>
        public ScriptProcessorNode CreateScriptProcessor(uint bufferSize, uint numberOfInputChannels, uint numberOfOutputChannels)
        {
            return null;
        }

        /// <summary>
        /// Creates a AnalyserNode.
        /// </summary>
        /// <returns>The newly created AnalyserNode object.</returns>
        public AnalyserNode CreateAnalyser()
        {
            return null;
        }

        /// <summary>
        /// Creates a GainNode.
        /// </summary>
        /// <returns>The newly created GainNode object.</returns>
        public GainNode CreateGain()
        {
            return null;
        }

        /// <summary>
        /// Creates a DelayNode representing a variable delay line. The initial default delay
        /// time will be 0 seconds.
        /// </summary>
        /// <returns>The newly created DelayNode object.</returns>
        public DelayNode CreateDelay()
        {
            return null;
        }

        /// <summary>
        /// Creates a DelayNode representing a variable delay line. The initial default delay
        /// time will be 0 seconds.
        /// </summary>
        /// <param name="maxDelayTime">The maxDelayTime parameter specifies the maximum 
        /// delay time in seconds allowed for the delay line. If specified, this value 
        /// must be greater than zero and less than three minutes or a NOT_SUPPORTED_ERR
        /// exception will be thrown.</param>
        /// <returns>The newly created DelayNode object.</returns>
        public DelayNode CreateDelay(double maxDelayTime)
        {
            return null;
        }

        /// <summary>
        /// Creates a BiquadFilterNode representing a second order filter which can be 
        /// configured as one of several common filter types.
        /// </summary>
        /// <returns>The newly created BiquadFilterNode object.</returns>
        public BiquadFilterNode CreateBiquadFilter()
        {
            return null;
        }

        /// <summary>
        /// Creates a WaveShaperNode representing a non-linear distortion.
        /// </summary>
        /// <returns>The newly created WaveShaperNode object.</returns>
        public WaveShaperNode CreateWaveShaper()
        {
            return null;
        }

        /// <summary>
        /// Creates a PannerNode.
        /// </summary>
        /// <returns>The newly created PannerNode object.</returns>
        public PannerNode CreatePanner()
        {
            return null;
        }

        /// <summary>
        /// Creates a ConvolverNode.
        /// </summary>
        /// <returns>The newly created ConvolverNode object.</returns>
        public ConvolverNode CreateConvolver()
        {
            return null;
        }

        /// <summary>
        /// Creates an ChannelSplitterNode representing a channel splitter.
        /// The default number of 6 outputs will be used.
        /// </summary>
        /// <returns>The newly created ChannelSplitterNode object.</returns>
        public ChannelSplitterNode CreateChannelSplitter()
        {
            return null;
        }

        /// <summary>
        /// Creates an ChannelSplitterNode representing a channel splitter.
        /// An exception will be thrown for invalid parameter values.
        /// </summary>
        /// <param name="numberOfOutputs">The numberOfOutputs parameter determines
        /// the number of outputs. Values of up to 32 must be supported.</param>
        /// <returns>The newly created ChannelSplitterNode object.</returns>
        public ChannelSplitterNode CreateChannelSplitter(uint numberOfOutputs)
        {
            return null;
        }

        /// <summary>
        /// Creates an ChannelMergerNode representing a channel merger.
        /// The default number of 6 inputs will be used.
        /// </summary>
        /// <returns>The newly created ChannelMergerNode object.</returns>
        public ChannelMergerNode CreateChannelMerger()
        {
            return null;
        }

        /// <summary>
        /// Creates an ChannelMergerNode representing a channel merger.
        /// An exception will be thrown for invalid parameter values.
        /// </summary>
        /// <param name="numberOfInputs">The numberOfInputs parameter determines the 
        /// number of inputs. Values of up to 32 must be supported.</param>
        /// <returns>The newly created ChannelMergerNode object.</returns>
        public ChannelMergerNode CreateChannelMerger(uint numberOfInputs)
        {
            return null;
        }

        /// <summary>
        /// Creates a DynamicsCompressorNode.
        /// </summary>
        /// <returns>The newly created DynamicsCompressorNode object.</returns>
        public DynamicsCompressorNode CreateDynamicsCompressor()
        {
            return null;
        }

        /// <summary>
        /// Creates an OscillatorNode.
        /// </summary>
        /// <returns>The newly created OscillatorNode object.</returns>
        public OscillatorNode CreateOscillator()
        {
            return null;
        }

        /// <summary>
        /// Creates a WaveTable representing a waveform containing arbitrary harmonic content.  The
        /// real and imag parameters specify the Fourier coefficients of a Fourier series representing the
        /// partials of a periodic waveform. The created WaveTable will be used with an OscillatorNode and 
        /// will represent a normalized time-domain waveform having maximum absolute peak value of 1. Another 
        /// way of saying this is that the generated waveform of an OscillatorNode will have maximum peak 
        /// value at 0dBFS. Conveniently, this corresponds to the full-range of the signal values used by the 
        /// Web Audio API. Because the WaveTable will be normalized on creation, the real and imag parameters 
        /// represent relative values.
        /// </summary>
        /// <param name="real">The real parameter represents an array of cosine terms (traditionally 
        /// the A terms). In audio terminology, the first element (index 0) is the DC-offset of the periodic 
        /// waveform and is usually set to zero. The second element (index 1) represents the fundamental 
        /// frequency. The third element represents the first overtone, and so on.
        /// 
        /// The supplied Float32Array must have a length greater than zero and less than or
        /// equal to 4096 or an exception will be thrown.</param>
        /// <param name="imag">The imag parameter represents an array of sine terms (traditionally 
        /// the B terms). The first element (index 0) should be set to zero (and will be ignored) since 
        /// this term does not exist in the Fourier series. The second element (index 1) represents the 
        /// fundamental frequency. The third element represents the first overtone, and so on.
        /// 
        /// The supplied Float32Array must have a length greater than zero and less than or
        /// equal to 4096 or an exception will be thrown.</param>
        /// <returns>The newly created WaveTable object.</returns>
        public WaveTable CreateWaveTable(Float32Array real, Float32Array imag)
        {
            return null;
        }
    }
}
