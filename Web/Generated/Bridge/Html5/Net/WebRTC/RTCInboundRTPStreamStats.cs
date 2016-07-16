namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCInboundRTPStreamStats : RTCRTPStreamStats
	{
		public ulong BytesReceived
		{
			get;
			set;
		}

		public double Jitter
		{
			get;
			set;
		}

		public int PacketsLost
		{
			get;
			set;
		}

		public int PacketsReceived
		{
			get;
			set;
		}
	}
}
