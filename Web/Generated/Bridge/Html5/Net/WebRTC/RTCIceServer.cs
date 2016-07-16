namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceServer
	{
		public extern string Credential
		{
			get;
			set;
		}

		public extern string Url
		{
			get;
			set;
		}

		public extern string Username
		{
			get;
			set;
		}
	}
}
