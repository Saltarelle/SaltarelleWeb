using System.Collections.TypedArrays;
using System.Html.Media.Graphics.WebGL;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WaveShaperNode : AudioNode {
		internal WaveShaperNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<WaveShaperNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<WaveShaperNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public Float32Array Curve {
			get {
				return default(Float32Array);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public OverSampleType Oversample {
			get {
				return default(OverSampleType);
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WaveShaperNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WaveShaperNode> listener, bool capture) {
		}
	}
}
