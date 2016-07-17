namespace Bridge.Html5.Media.Graphics
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class VideoPlaybackQuality
	{
		internal extern VideoPlaybackQuality();

		public readonly int CorruptedVideoFrames;

		public readonly double CreationTime;

		public readonly int DroppedVideoFrames;

		public readonly int TotalVideoFrames;
	}
}
