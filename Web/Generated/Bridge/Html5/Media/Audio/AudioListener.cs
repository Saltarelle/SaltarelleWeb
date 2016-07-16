namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioListener
	{
		internal extern AudioListener();

		[FieldProperty]
		public extern double DopplerFactor
		{
			get;
			set;
		}

		public extern void SetOrientation(double x, double y, double z, double xUp, double yUp, double zUp);

		public extern void SetPosition(double x, double y, double z);

		public extern void SetVelocity(double x, double y, double z);

		[FieldProperty]
		public extern double SpeedOfSound
		{
			get;
			set;
		}
	}
}
