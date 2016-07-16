using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern int FftSize
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int FrequencyBinCount
		{
			get;
		}

		public extern void GetByteFrequencyData(Uint8Array array);

		public extern void GetByteTimeDomainData(Uint8Array array);

		public extern void GetFloatFrequencyData(Float32Array array);

		public extern void GetFloatTimeDomainData(Float32Array array);

		[FieldProperty]
		public extern double MaxDecibels
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double MinDecibels
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern double SmoothingTimeConstant
		{
			get;
			set;
		}
	}
}
