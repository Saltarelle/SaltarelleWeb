namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class MediaConstraints
	{
		public object Mandatory
		{
			get;
			set;
		}

		public MediaConstraintSet[] Optional
		{
			get;
			set;
		}
	}
}
