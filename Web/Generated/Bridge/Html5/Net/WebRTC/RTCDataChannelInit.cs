namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCDataChannelInit
	{
		public ushort? Id;

		public ushort MaxRetransmitNum;

		public ushort? MaxRetransmits;

		public ushort? MaxRetransmitTime;

		public bool Negotiated;

		public bool Ordered;

		public bool OutOfOrderAllowed;

		public bool Preset;

		public string Protocol;

		public ushort Stream;
	}
}
