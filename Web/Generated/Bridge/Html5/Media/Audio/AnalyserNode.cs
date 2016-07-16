using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AnalyserNode : AudioNode
	{
		internal AnalyserNode()
		{
		}

		public void AddEventListener(AnalyserNodeEvents type, Action listener)
		{
		}

		public void AddEventListener(AnalyserNodeEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(AnalyserNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(AnalyserNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener)
		{
		}

		public void AddEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture)
		{
		}

		public void AddEventListener(AnalyserNodeEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(AnalyserNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture)
		{
		}

		[FieldProperty]
		public int FftSize
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int FrequencyBinCount
		{
			get {
				return 0;
			}
		}

		public void GetByteFrequencyData(Uint8Array array)
		{
		}

		public void GetByteTimeDomainData(Uint8Array array)
		{
		}

		public void GetFloatFrequencyData(Float32Array array)
		{
		}

		public void GetFloatTimeDomainData(Float32Array array)
		{
		}

		[FieldProperty]
		public double MaxDecibels
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public double MinDecibels
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void RemoveEventListener(AnalyserNodeEvents type, Action listener)
		{
		}

		public void RemoveEventListener(AnalyserNodeEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener)
		{
		}

		public void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture)
		{
		}

		public void RemoveEventListener(AnalyserNodeEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(AnalyserNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture)
		{
		}

		[FieldProperty]
		public double SmoothingTimeConstant
		{
			get {
				return 0;
			}
			set {
			}
		}
	}
}
