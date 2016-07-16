namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class RTCIceCandidate
	{
		public extern RTCIceCandidate();

		public extern RTCIceCandidate(RTCIceCandidateInit candidateInitDict);

		[FieldProperty]
		public extern string Candidate
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string SdpMid
		{
			get;
			set;
		}

		[FieldProperty]
		public extern ushort? SdpMLineIndex
		{
			get;
			set;
		}
	}
}
