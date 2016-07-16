namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("mozRTCSessionDescription")]
	public partial class RTCSessionDescription
	{
		public RTCSessionDescription()
		{
		}

		public RTCSessionDescription(RTCSessionDescriptionInit descriptionInitDict)
		{
		}

		[FieldProperty]
		public string Sdp
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public RTCSdpType? Type
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
