namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class RTCIceCandidate
	{
		public extern RTCIceCandidate();

		public extern RTCIceCandidate(RTCIceCandidateInit candidateInitDict);

		public string Candidate;

		public string SdpMid;

		public ushort? SdpMLineIndex;
	}
}
