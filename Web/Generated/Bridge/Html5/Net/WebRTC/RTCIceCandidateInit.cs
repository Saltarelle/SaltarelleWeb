namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceCandidateInit
	{
		public string Candidate;

		public string SdpMid;

		public ushort SdpMLineIndex;
	}
}
