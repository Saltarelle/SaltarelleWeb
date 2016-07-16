namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCTransportStats : RTCStats
	{
		public extern int BytesReceived
		{
			get;
			set;
		}

		public extern int BytesSent
		{
			get;
			set;
		}
	}
}
