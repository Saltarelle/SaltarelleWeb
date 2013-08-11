using System.Html.Media.Audio;
using System.Html.Media.Graphics;
using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaStream {
		internal MediaStream() {
		}

		[IntrinsicProperty]
		public double CurrentTime {
			get { return 0; }
		}

		public AudioStreamTrack[] GetAudioTracks() {
			return null;
		}

		public VideoStreamTrack[] GetVideoTracks() {
			return null;
		}
	}
}
