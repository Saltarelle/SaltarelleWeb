namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceCandidatePairStats : RTCStats
	{
		public string ComponentId
		{
			get;
			set;
		}

		public string LocalCandidateId
		{
			get;
			set;
		}

		public bool Nominated
		{
			get;
			set;
		}

		public bool Readable
		{
			get;
			set;
		}

		public string RemoteCandidateId
		{
			get;
			set;
		}

		public bool Selected
		{
			get;
			set;
		}

		public RTCStatsIceCandidatePairState State
		{
			get;
			set;
		}
	}
}
