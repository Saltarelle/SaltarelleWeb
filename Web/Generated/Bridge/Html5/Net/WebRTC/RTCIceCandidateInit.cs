namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceCandidateInit
	{
		public string Candidate
		{
			get;
			set;
		}

		public string SdpMid
		{
			get;
			set;
		}

		public ushort SdpMLineIndex
		{
			get;
			set;
		}
	}
}
