namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCMediaStreamStats : RTCStats
	{
		public extern string StreamIdentifier
		{
			get;
			set;
		}

		public extern string[] TrackIds
		{
			get;
			set;
		}
	}
}
