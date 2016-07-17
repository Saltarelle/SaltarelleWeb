namespace Bridge.Html5.Net.WebRTC
{
	[Namespace(false), External, Name("mozRTCSessionDescription")]
	public partial class RTCSessionDescription
	{
		public extern RTCSessionDescription();

		public extern RTCSessionDescription(RTCSessionDescriptionInit descriptionInitDict);

		public string Sdp;

		public RTCSdpType? Type;
	}
}
