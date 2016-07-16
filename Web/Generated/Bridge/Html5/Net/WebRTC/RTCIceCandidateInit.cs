namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceCandidateInit
	{
		public extern string Candidate
		{
			get;
			set;
		}

		public extern string SdpMid
		{
			get;
			set;
		}

		public extern ushort SdpMLineIndex
		{
			get;
			set;
		}
	}
}
