namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCOutboundRTPStreamStats : RTCRTPStreamStats
	{
		public extern ulong BytesSent
		{
			get;
			set;
		}

		public extern int PacketsSent
		{
			get;
			set;
		}
	}
}
