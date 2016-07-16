namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCDataChannelEventInit : EventInit
	{
		public extern RTCDataChannel Channel
		{
			get;
			set;
		}
	}
}
