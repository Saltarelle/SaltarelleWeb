using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DynamicsCompressorNode : AudioNode {
		internal DynamicsCompressorNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public AudioParam Attack {
			get {
				return default(AudioParam);
			}
		}

		[IntrinsicProperty]
		public AudioParam Knee {
			get {
				return default(AudioParam);
			}
		}

		[IntrinsicProperty]
		public AudioParam Ratio {
			get {
				return default(AudioParam);
			}
		}

		[IntrinsicProperty]
		public AudioParam Reduction {
			get {
				return default(AudioParam);
			}
		}

		[IntrinsicProperty]
		public AudioParam Release {
			get {
				return default(AudioParam);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public AudioParam Threshold {
			get {
				return default(AudioParam);
			}
		}
	}
}
