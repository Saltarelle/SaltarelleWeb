using System.Html.Media.Graphics;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'VIDEO'"), ScriptName("Element")]
	public partial class VideoElement : MediaElement {
		internal VideoElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<VideoElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<VideoElement> listener, bool capture) {
		}

		public VideoPlaybackQuality GetVideoPlaybackQuality() {
			return default(VideoPlaybackQuality);
		}

		[IntrinsicProperty]
		public uint Height {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Poster {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<VideoElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<VideoElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public uint VideoHeight {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public uint VideoWidth {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public uint Width {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
