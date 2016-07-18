namespace Bridge.Html5.Net.WebRTC
{
	[External]
	public partial class RTCMediaStreamTrackStats : RTCStats
	{
		public int AudioLevel;

		public int FrameHeight;

		public int FramesDecoded;

		public double FramesPerSecond;

		public int FramesReceived;

		public int FramesSent;

		public int FrameWidth;

		public bool RemoteSource;

		public string[] SsrcIds;

		public string TrackIdentifier;
	}
}
