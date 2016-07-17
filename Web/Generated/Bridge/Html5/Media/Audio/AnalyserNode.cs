using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace(false), External]
	public partial class AnalyserNode : AudioNode
	{
		internal extern AnalyserNode();

		public extern void AddEventListener(AnalyserNodeEvents type, Action listener);

		public extern void AddEventListener(AnalyserNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(AnalyserNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AnalyserNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener);

		public extern void AddEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture);

		public extern void AddEventListener(AnalyserNodeEvents type, IEventListener listener);

		public extern void AddEventListener(AnalyserNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture);

		public int FftSize;

		public readonly int FrequencyBinCount;

		public extern void GetByteFrequencyData(Uint8Array array);

		public extern void GetByteTimeDomainData(Uint8Array array);

		public extern void GetFloatFrequencyData(Float32Array array);

		public extern void GetFloatTimeDomainData(Float32Array array);

		public double MaxDecibels;

		public double MinDecibels;

		public extern void RemoveEventListener(AnalyserNodeEvents type, Action listener);

		public extern void RemoveEventListener(AnalyserNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener);

		public extern void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture);

		public extern void RemoveEventListener(AnalyserNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(AnalyserNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture);

		public double SmoothingTimeConstant;
	}
}
