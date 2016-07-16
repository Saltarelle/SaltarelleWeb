namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceComponentStats : RTCStats
	{
		public extern bool ActiveConnection
		{
			get;
			set;
		}

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

		public extern int Component
		{
			get;
			set;
		}

		public extern string TransportId
		{
			get;
			set;
		}
	}
}
