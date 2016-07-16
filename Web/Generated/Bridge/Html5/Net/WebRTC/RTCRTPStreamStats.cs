namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCRTPStreamStats : RTCStats
	{
		public string CodecId
		{
			get;
			set;
		}

		public bool IsRemote
		{
			get;
			set;
		}

		public string MediaTrackId
		{
			get;
			set;
		}

		public string RemoteId
		{
			get;
			set;
		}

		public string Ssrc
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
