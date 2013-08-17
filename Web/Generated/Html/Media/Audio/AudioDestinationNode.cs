using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AudioDestinationNode : AudioNode {
		internal AudioDestinationNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public uint MaxChannelCount {
			get {
				return 0;
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioDestinationNode> listener, bool capture) {
		}
	}
}
