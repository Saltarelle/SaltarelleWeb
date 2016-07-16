namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCInboundRTPStreamStats : RTCRTPStreamStats
	{
		public extern ulong BytesReceived
		{
			get;
			set;
		}

		public extern double Jitter
		{
			get;
			set;
		}

		public extern int PacketsLost
		{
			get;
			set;
		}

		public extern int PacketsReceived
		{
			get;
			set;
		}
	}
}
