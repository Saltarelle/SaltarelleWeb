using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioContext : EventTarget
	{
		public void AddEventListener(AudioContextEvents type, Action listener)
		{
		}

		public void AddEventListener(AudioContextEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(AudioContextEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(AudioContextEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(AudioContextEvents type, HtmlEventHandlerWithTarget<AudioContext> listener)
		{
		}

		public void AddEventListener(AudioContextEvents type, HtmlEventHandlerWithTarget<AudioContext> listener, bool capture)
		{
		}

		public void AddEventListener(AudioContextEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(AudioContextEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioContext> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioContext> listener, bool capture)
		{
		}

		public AnalyserNode CreateAnalyser()
		{
			return default(AnalyserNode);
		}

		public BiquadFilterNode CreateBiquadFilter()
		{
			return default(BiquadFilterNode);
		}

		public AudioBuffer CreateBuffer(ArrayBuffer buffer, bool mixToMono)
		{
			return default(AudioBuffer);
		}

		public AudioBuffer CreateBuffer(int numberOfChannels, int length, double sampleRate)
		{
			return default(AudioBuffer);
		}

		public AudioBufferSourceNode CreateBufferSource()
		{
			return default(AudioBufferSourceNode);
		}

		public ChannelMergerNode CreateChannelMerger()
		{
			return default(ChannelMergerNode);
		}

		public ChannelMergerNode CreateChannelMerger(int numberOfInputs)
		{
			return default(ChannelMergerNode);
		}

		public ChannelSplitterNode CreateChannelSplitter()
		{
			return default(ChannelSplitterNode);
		}

		public ChannelSplitterNode CreateChannelSplitter(int numberOfOutputs)
		{
			return default(ChannelSplitterNode);
		}

		public ConvolverNode CreateConvolver()
		{
			return default(ConvolverNode);
		}

		public DelayNode CreateDelay()
		{
			return default(DelayNode);
		}

		public DelayNode CreateDelay(double maxDelayTime)
		{
			return default(DelayNode);
		}

		public DelayNode CreateDelayNode()
		{
			return default(DelayNode);
		}

		public DelayNode CreateDelayNode(double maxDelayTime)
		{
			return default(DelayNode);
		}

		public DynamicsCompressorNode CreateDynamicsCompressor()
		{
			return default(DynamicsCompressorNode);
		}

		public GainNode CreateGain()
		{
			return default(GainNode);
		}

		public GainNode CreateGainNode()
		{
			return default(GainNode);
		}

		public ScriptProcessorNode CreateJavaScriptNode()
		{
			return default(ScriptProcessorNode);
		}

		public ScriptProcessorNode CreateJavaScriptNode(int bufferSize)
		{
			return default(ScriptProcessorNode);
		}

		public ScriptProcessorNode CreateJavaScriptNode(int bufferSize, int numberOfInputChannels)
		{
			return default(ScriptProcessorNode);
		}

		public ScriptProcessorNode CreateJavaScriptNode(int bufferSize, int numberOfInputChannels, int numberOfOutputChannels)
		{
			return default(ScriptProcessorNode);
		}

		public MediaElementAudioSourceNode CreateMediaElementSource(MediaElement mediaElement)
		{
			return default(MediaElementAudioSourceNode);
		}

		public MediaStreamAudioDestinationNode CreateMediaStreamDestination()
		{
			return default(MediaStreamAudioDestinationNode);
		}

		public MediaStreamAudioSourceNode CreateMediaStreamSource(MediaStream mediaStream)
		{
			return default(MediaStreamAudioSourceNode);
		}

		public OscillatorNode CreateOscillator()
		{
			return default(OscillatorNode);
		}

		public PannerNode CreatePanner()
		{
			return default(PannerNode);
		}

		public PeriodicWave CreatePeriodicWave(Float32Array real, Float32Array imag)
		{
			return default(PeriodicWave);
		}

		public ScriptProcessorNode CreateScriptProcessor()
		{
			return default(ScriptProcessorNode);
		}

		public ScriptProcessorNode CreateScriptProcessor(int bufferSize)
		{
			return default(ScriptProcessorNode);
		}

		public ScriptProcessorNode CreateScriptProcessor(int bufferSize, int numberOfInputChannels)
		{
			return default(ScriptProcessorNode);
		}

		public ScriptProcessorNode CreateScriptProcessor(int bufferSize, int numberOfInputChannels, int numberOfOutputChannels)
		{
			return default(ScriptProcessorNode);
		}

		public WaveShaperNode CreateWaveShaper()
		{
			return default(WaveShaperNode);
		}

		[FieldProperty]
		public double CurrentTime
		{
			get {
				return 0;
			}
		}

		public void DecodeAudioData(ArrayBuffer audioData, DecodeSuccessCallback successCallback)
		{
		}

		public void DecodeAudioData(ArrayBuffer audioData, DecodeSuccessCallback successCallback, DecodeErrorCallback errorCallback)
		{
		}

		[FieldProperty]
		public AudioDestinationNode Destination
		{
			get {
				return default(AudioDestinationNode);
			}
		}

		[FieldProperty]
		public AudioListener Listener
		{
			get {
				return default(AudioListener);
			}
		}

		public void RemoveEventListener(AudioContextEvents type, Action listener)
		{
		}

		public void RemoveEventListener(AudioContextEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioContextEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(AudioContextEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioContextEvents type, HtmlEventHandlerWithTarget<AudioContext> listener)
		{
		}

		public void RemoveEventListener(AudioContextEvents type, HtmlEventHandlerWithTarget<AudioContext> listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioContextEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(AudioContextEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioContext> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioContext> listener, bool capture)
		{
		}

		[FieldProperty]
		public double SampleRate
		{
			get {
				return 0;
			}
		}
	}
}
