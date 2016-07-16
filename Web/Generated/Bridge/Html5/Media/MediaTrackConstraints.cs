namespace Bridge.Html5.Media
{
	[External, Serializable]
	public partial class MediaTrackConstraints
	{
		public object Mandatory
		{
			get;
			set;
		}

		public MediaTrackConstraintSet[] Optional
		{
			get;
			set;
		}
	}
}
