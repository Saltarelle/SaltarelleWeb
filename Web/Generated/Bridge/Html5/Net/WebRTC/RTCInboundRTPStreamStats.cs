namespace Bridge.Html5.Net.WebRTC
{
	[External]
	public partial class RTCInboundRTPStreamStats : RTCRTPStreamStats
	{
		public ulong BytesReceived;

		public double Jitter;

		public int PacketsLost;

		public int PacketsReceived;
	}
}
