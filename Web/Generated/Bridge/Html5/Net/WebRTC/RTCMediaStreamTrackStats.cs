namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCMediaStreamTrackStats : RTCStats
	{
		public extern int AudioLevel
		{
			get;
			set;
		}

		public extern int FrameHeight
		{
			get;
			set;
		}

		public extern int FramesDecoded
		{
			get;
			set;
		}

		public extern double FramesPerSecond
		{
			get;
			set;
		}

		public extern int FramesReceived
		{
			get;
			set;
		}

		public extern int FramesSent
		{
			get;
			set;
		}

		public extern int FrameWidth
		{
			get;
			set;
		}

		public extern bool RemoteSource
		{
			get;
			set;
		}

		public extern string[] SsrcIds
		{
			get;
			set;
		}

		public extern string TrackIdentifier
		{
			get;
			set;
		}
	}
}
