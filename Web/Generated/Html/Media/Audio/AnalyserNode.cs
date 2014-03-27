using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AnalyserNode : AudioNode {
		internal AnalyserNode() {
		}

		public void AddEventListener(AnalyserNodeEvents type, Action listener) {
		}

		public void AddEventListener(AnalyserNodeEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(AnalyserNodeEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(AnalyserNodeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener) {
		}

		public void AddEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture) {
		}

		public void AddEventListener(AnalyserNodeEvents type, IEventListener listener) {
		}

		public void AddEventListener(AnalyserNodeEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public int FftSize {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int FrequencyBinCount {
			get {
				return 0;
			}
		}

		public void GetByteFrequencyData(Uint8Array array) {
		}

		public void GetByteTimeDomainData(Uint8Array array) {
		}

		public void GetFloatFrequencyData(Float32Array array) {
		}

		public void GetFloatTimeDomainData(Float32Array array) {
		}

		[IntrinsicProperty]
		public double MaxDecibels {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double MinDecibels {
			get {
				return 0;
			}
			set {
			}
		}

		public void RemoveEventListener(AnalyserNodeEvents type, Action listener) {
		}

		public void RemoveEventListener(AnalyserNodeEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener) {
		}

		public void RemoveEventListener(AnalyserNodeEvents type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture) {
		}

		public void RemoveEventListener(AnalyserNodeEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(AnalyserNodeEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AnalyserNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public double SmoothingTimeConstant {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
