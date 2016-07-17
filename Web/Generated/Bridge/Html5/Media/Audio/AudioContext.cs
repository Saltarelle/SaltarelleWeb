using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioContext : EventTarget
	{
		public extern void AddEventListener(AudioContextEvents type, Action listener);

		public extern void AddEventListener(AudioContextEvents type, Action listener, bool capture);

		public extern void AddEventListener(AudioContextEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AudioContextEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AudioContextEvents type, HtmlEventHandlerWithTarget<AudioContext> listener);

		public extern void AddEventListener(AudioContextEvents type, HtmlEventHandlerWithTarget<AudioContext> listener, bool capture);

		public extern void AddEventListener(AudioContextEvents type, IEventListener listener);

		public extern void AddEventListener(AudioContextEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioContext> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioContext> listener, bool capture);

		public extern AnalyserNode CreateAnalyser();

		public extern BiquadFilterNode CreateBiquadFilter();

		public extern AudioBuffer CreateBuffer(ArrayBuffer buffer, bool mixToMono);

		public extern AudioBuffer CreateBuffer(int numberOfChannels, int length, double sampleRate);

		public extern AudioBufferSourceNode CreateBufferSource();

		public extern ChannelMergerNode CreateChannelMerger();

		public extern ChannelMergerNode CreateChannelMerger(int numberOfInputs);

		public extern ChannelSplitterNode CreateChannelSplitter();

		public extern ChannelSplitterNode CreateChannelSplitter(int numberOfOutputs);

		public extern ConvolverNode CreateConvolver();

		public extern DelayNode CreateDelay();

		public extern DelayNode CreateDelay(double maxDelayTime);

		public extern DelayNode CreateDelayNode();

		public extern DelayNode CreateDelayNode(double maxDelayTime);

		public extern DynamicsCompressorNode CreateDynamicsCompressor();

		public extern GainNode CreateGain();

		public extern GainNode CreateGainNode();

		public extern ScriptProcessorNode CreateJavaScriptNode();

		public extern ScriptProcessorNode CreateJavaScriptNode(int bufferSize);

		public extern ScriptProcessorNode CreateJavaScriptNode(int bufferSize, int numberOfInputChannels);

		public extern ScriptProcessorNode CreateJavaScriptNode(int bufferSize, int numberOfInputChannels, int numberOfOutputChannels);

		public extern MediaElementAudioSourceNode CreateMediaElementSource(MediaElement mediaElement);

		public extern MediaStreamAudioDestinationNode CreateMediaStreamDestination();

		public extern MediaStreamAudioSourceNode CreateMediaStreamSource(MediaStream mediaStream);

		public extern OscillatorNode CreateOscillator();

		public extern PannerNode CreatePanner();

		public extern PeriodicWave CreatePeriodicWave(Float32Array real, Float32Array imag);

		public extern ScriptProcessorNode CreateScriptProcessor();

		public extern ScriptProcessorNode CreateScriptProcessor(int bufferSize);

		public extern ScriptProcessorNode CreateScriptProcessor(int bufferSize, int numberOfInputChannels);

		public extern ScriptProcessorNode CreateScriptProcessor(int bufferSize, int numberOfInputChannels, int numberOfOutputChannels);

		public extern WaveShaperNode CreateWaveShaper();

		public readonly double CurrentTime;

		public extern void DecodeAudioData(ArrayBuffer audioData, DecodeSuccessCallback successCallback);

		public extern void DecodeAudioData(ArrayBuffer audioData, DecodeSuccessCallback successCallback, DecodeErrorCallback errorCallback);

		public readonly AudioDestinationNode Destination;

		public readonly AudioListener Listener;

		public extern void RemoveEventListener(AudioContextEvents type, Action listener);

		public extern void RemoveEventListener(AudioContextEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AudioContextEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AudioContextEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AudioContextEvents type, HtmlEventHandlerWithTarget<AudioContext> listener);

		public extern void RemoveEventListener(AudioContextEvents type, HtmlEventHandlerWithTarget<AudioContext> listener, bool capture);

		public extern void RemoveEventListener(AudioContextEvents type, IEventListener listener);

		public extern void RemoveEventListener(AudioContextEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioContext> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioContext> listener, bool capture);

		public readonly double SampleRate;
	}
}
