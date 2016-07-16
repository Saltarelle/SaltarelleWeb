using Bridge.Html5.Media.Audio;
using Bridge.Html5.Media.Graphics;

namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaStream
	{
		internal MediaStream()
		{
		}

		[FieldProperty]
		public double CurrentTime
		{
			get {
				return 0;
			}
		}

		public AudioStreamTrack[] GetAudioTracks()
		{
			return null;
		}

		public VideoStreamTrack[] GetVideoTracks()
		{
			return null;
		}
	}
}
