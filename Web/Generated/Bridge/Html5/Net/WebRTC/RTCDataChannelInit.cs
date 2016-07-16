namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCDataChannelInit
	{
		public ushort? Id
		{
			get;
			set;
		}

		public ushort MaxRetransmitNum
		{
			get;
			set;
		}

		public ushort? MaxRetransmits
		{
			get;
			set;
		}

		public ushort? MaxRetransmitTime
		{
			get;
			set;
		}

		public bool Negotiated
		{
			get;
			set;
		}

		public bool Ordered
		{
			get;
			set;
		}

		public bool OutOfOrderAllowed
		{
			get;
			set;
		}

		public bool Preset
		{
			get;
			set;
		}

		public string Protocol
		{
			get;
			set;
		}

		public ushort Stream
		{
			get;
			set;
		}
	}
}
