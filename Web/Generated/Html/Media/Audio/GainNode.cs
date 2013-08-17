using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class GainNode : AudioNode {
		internal GainNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<GainNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<GainNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public AudioParam Gain {
			get {
				return default(AudioParam);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<GainNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<GainNode> listener, bool capture) {
		}
	}
}
