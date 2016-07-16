namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCMediaStreamStats : RTCStats
	{
		public string StreamIdentifier
		{
			get;
			set;
		}

		public string[] TrackIds
		{
			get;
			set;
		}
	}
}
