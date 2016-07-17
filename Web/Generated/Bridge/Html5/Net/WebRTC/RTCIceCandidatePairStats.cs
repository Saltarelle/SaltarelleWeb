namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceCandidatePairStats : RTCStats
	{
		public string ComponentId;

		public string LocalCandidateId;

		public bool Nominated;

		public bool Readable;

		public string RemoteCandidateId;

		public bool Selected;

		public RTCStatsIceCandidatePairState State;
	}
}
