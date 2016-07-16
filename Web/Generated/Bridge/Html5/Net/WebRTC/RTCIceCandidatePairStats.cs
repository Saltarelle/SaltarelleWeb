namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceCandidatePairStats : RTCStats
	{
		public extern string ComponentId
		{
			get;
			set;
		}

		public extern string LocalCandidateId
		{
			get;
			set;
		}

		public extern bool Nominated
		{
			get;
			set;
		}

		public extern bool Readable
		{
			get;
			set;
		}

		public extern string RemoteCandidateId
		{
			get;
			set;
		}

		public extern bool Selected
		{
			get;
			set;
		}

		public extern RTCStatsIceCandidatePairState State
		{
			get;
			set;
		}
	}
}
