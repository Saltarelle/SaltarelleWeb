namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceComponentStats : RTCStats
	{
		public bool ActiveConnection
		{
			get;
			set;
		}

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

		public int Component
		{
			get;
			set;
		}

		public string TransportId
		{
			get;
			set;
		}
	}
}
