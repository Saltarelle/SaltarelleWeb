namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCMediaStreamTrackStats : RTCStats
	{
		public int AudioLevel
		{
			get;
			set;
		}

		public int FrameHeight
		{
			get;
			set;
		}

		public int FramesDecoded
		{
			get;
			set;
		}

		public double FramesPerSecond
		{
			get;
			set;
		}

		public int FramesReceived
		{
			get;
			set;
		}

		public int FramesSent
		{
			get;
			set;
		}

		public int FrameWidth
		{
			get;
			set;
		}

		public bool RemoteSource
		{
			get;
			set;
		}

		public string[] SsrcIds
		{
			get;
			set;
		}

		public string TrackIdentifier
		{
			get;
			set;
		}
	}
}
