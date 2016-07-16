namespace Bridge.Html5.Media
{
	[External, Serializable]
	public partial class MediaTrackConstraints
	{
		public extern object Mandatory
		{
			get;
			set;
		}

		public extern MediaTrackConstraintSet[] Optional
		{
			get;
			set;
		}
	}
}
