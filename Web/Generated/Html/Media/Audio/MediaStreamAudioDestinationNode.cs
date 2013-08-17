using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaStreamAudioDestinationNode : AudioNode {
		internal MediaStreamAudioDestinationNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaStreamAudioDestinationNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public MediaStream Stream {
			get {
				return default(MediaStream);
			}
		}
	}
}
