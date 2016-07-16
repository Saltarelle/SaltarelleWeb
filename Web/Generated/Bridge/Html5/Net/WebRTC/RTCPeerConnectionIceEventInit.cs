namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCPeerConnectionIceEventInit : EventInit
	{
		public extern RTCIceCandidate Candidate
		{
			get;
			set;
		}
	}
}
