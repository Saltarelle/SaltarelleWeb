namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class MediaConstraints
	{
		public extern object Mandatory
		{
			get;
			set;
		}

		public extern MediaConstraintSet[] Optional
		{
			get;
			set;
		}
	}
}
