namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCConfiguration
	{
		public RTCIceServer[] IceServers
		{
			get;
			set;
		}
	}
}
