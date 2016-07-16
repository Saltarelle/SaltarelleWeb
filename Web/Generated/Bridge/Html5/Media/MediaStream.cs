using Bridge.Html5.Media.Audio;
using Bridge.Html5.Media.Graphics;

namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaStream
	{
		internal extern MediaStream();

		[FieldProperty]
		public extern double CurrentTime
		{
			get;
		}

		public extern AudioStreamTrack[] GetAudioTracks();

		public extern VideoStreamTrack[] GetVideoTracks();
	}
}
