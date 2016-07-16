namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class MediaConstraintSet
	{
		[Name("OfferToReceiveAudio")]
		public extern bool OfferToReceiveAudio
		{
			get;
			set;
		}

		[Name("OfferToReceiveVideo")]
		public extern bool OfferToReceiveVideo
		{
			get;
			set;
		}
	}
}
