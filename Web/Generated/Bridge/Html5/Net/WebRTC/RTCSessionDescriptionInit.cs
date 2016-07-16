namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCSessionDescriptionInit
	{
		public extern string Sdp
		{
			get;
			set;
		}

		public extern RTCSdpType? Type
		{
			get;
			set;
		}
	}
}
