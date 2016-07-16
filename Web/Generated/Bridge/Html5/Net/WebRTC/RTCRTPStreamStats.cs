namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCRTPStreamStats : RTCStats
	{
		public extern string CodecId
		{
			get;
			set;
		}

		public extern bool IsRemote
		{
			get;
			set;
		}

		public extern string MediaTrackId
		{
			get;
			set;
		}

		public extern string RemoteId
		{
			get;
			set;
		}

		public extern string Ssrc
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
