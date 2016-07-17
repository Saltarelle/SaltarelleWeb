namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCMediaStreamStats : RTCStats
	{
		public string StreamIdentifier;

		public string[] TrackIds;
	}
}
