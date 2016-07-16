namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCCodecStats : RTCStats
	{
		public extern int Channels
		{
			get;
			set;
		}

		public extern int ClockRate
		{
			get;
			set;
		}

		public extern string Codec
		{
			get;
			set;
		}

		public extern string Parameters
		{
			get;
			set;
		}

		public extern int PayloadType
		{
			get;
			set;
		}
	}
}
