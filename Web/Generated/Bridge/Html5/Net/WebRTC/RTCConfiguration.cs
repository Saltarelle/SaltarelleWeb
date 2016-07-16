namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCConfiguration
	{
		public extern RTCIceServer[] IceServers
		{
			get;
			set;
		}
	}
}
