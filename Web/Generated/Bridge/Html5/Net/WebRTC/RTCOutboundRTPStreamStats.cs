namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCOutboundRTPStreamStats : RTCRTPStreamStats
	{
		public ulong BytesSent;

		public int PacketsSent;
	}
}
