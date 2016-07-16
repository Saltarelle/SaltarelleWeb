namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCTransportStats : RTCStats
	{
		public int BytesReceived
		{
			get;
			set;
		}

		public int BytesSent
		{
			get;
			set;
		}
	}
}
