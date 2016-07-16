namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCSessionDescriptionInit
	{
		public string Sdp
		{
			get;
			set;
		}

		public RTCSdpType? Type
		{
			get;
			set;
		}
	}
}
