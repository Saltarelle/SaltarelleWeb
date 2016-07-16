namespace Bridge.Html5.Media.Graphics
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class VideoPlaybackQuality
	{
		internal VideoPlaybackQuality()
		{
		}

		[FieldProperty]
		public int CorruptedVideoFrames
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double CreationTime
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int DroppedVideoFrames
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int TotalVideoFrames
		{
			get {
				return 0;
			}
		}
	}
}
