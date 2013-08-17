using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ConvolverNode : AudioNode {
		internal ConvolverNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ConvolverNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ConvolverNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public AudioBuffer Buffer {
			get {
				return default(AudioBuffer);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Normalize {
			get {
				return false;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ConvolverNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ConvolverNode> listener, bool capture) {
		}
	}
}
