using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DelayNode : AudioNode {
		internal DelayNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DelayNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<DelayNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public AudioParam DelayTime {
			get {
				return default(AudioParam);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DelayNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DelayNode> listener, bool capture) {
		}
	}
}
