namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class MediaConstraintSet
	{
		[Name("OfferToReceiveAudio")]
		public bool OfferToReceiveAudio;

		[Name("OfferToReceiveVideo")]
		public bool OfferToReceiveVideo;
	}
}
