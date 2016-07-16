namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class RTCPeerConnectionIceEvent : Event
	{
		internal RTCPeerConnectionIceEvent()
		{
		}

		public RTCPeerConnectionIceEvent(string type)
		{
		}

		public RTCPeerConnectionIceEvent(string type, RTCPeerConnectionIceEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public RTCIceCandidate Candidate
		{
			get {
				return default(RTCIceCandidate);
			}
		}
	}
}
