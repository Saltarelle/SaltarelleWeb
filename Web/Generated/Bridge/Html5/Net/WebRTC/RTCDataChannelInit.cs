namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCDataChannelInit
	{
		public extern ushort? Id
		{
			get;
			set;
		}

		public extern ushort MaxRetransmitNum
		{
			get;
			set;
		}

		public extern ushort? MaxRetransmits
		{
			get;
			set;
		}

		public extern ushort? MaxRetransmitTime
		{
			get;
			set;
		}

		public extern bool Negotiated
		{
			get;
			set;
		}

		public extern bool Ordered
		{
			get;
			set;
		}

		public extern bool OutOfOrderAllowed
		{
			get;
			set;
		}

		public extern bool Preset
		{
			get;
			set;
		}

		public extern string Protocol
		{
			get;
			set;
		}

		public extern ushort Stream
		{
			get;
			set;
		}
	}
}
