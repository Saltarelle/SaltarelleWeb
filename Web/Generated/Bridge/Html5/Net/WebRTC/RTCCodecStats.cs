namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCCodecStats : RTCStats
	{
		public int Channels;

		public int ClockRate;

		public string Codec;

		public string Parameters;

		public int PayloadType;
	}
}
