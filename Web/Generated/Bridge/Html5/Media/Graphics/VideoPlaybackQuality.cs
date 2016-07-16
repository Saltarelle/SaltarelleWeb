namespace Bridge.Html5.Media.Graphics
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class VideoPlaybackQuality
	{
		internal extern VideoPlaybackQuality();

		[FieldProperty]
		public extern int CorruptedVideoFrames
		{
			get;
		}

		[FieldProperty]
		public extern double CreationTime
		{
			get;
		}

		[FieldProperty]
		public extern int DroppedVideoFrames
		{
			get;
		}

		[FieldProperty]
		public extern int TotalVideoFrames
		{
			get;
		}
	}
}
