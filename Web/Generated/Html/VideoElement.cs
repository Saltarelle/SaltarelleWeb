using System.Html.Media.Graphics;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'VIDEO'"), ScriptName("Element")]
	public partial class VideoElement : MediaElement {
		internal VideoElement() {
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
