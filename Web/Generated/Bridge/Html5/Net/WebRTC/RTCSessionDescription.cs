namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("mozRTCSessionDescription")]
	public partial class RTCSessionDescription
	{
		public extern RTCSessionDescription();

		public extern RTCSessionDescription(RTCSessionDescriptionInit descriptionInitDict);

		[FieldProperty]
		public extern string Sdp
		{
			get;
			set;
		}

		[FieldProperty]
		public extern RTCSdpType? Type
		{
			get;
			set;
		}
	}
}
