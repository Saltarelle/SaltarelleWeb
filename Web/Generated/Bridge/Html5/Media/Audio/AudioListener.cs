namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioListener
	{
		internal AudioListener()
		{
		}

		[FieldProperty]
		public double DopplerFactor
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void SetOrientation(double x, double y, double z, double xUp, double yUp, double zUp)
		{
		}

		public void SetPosition(double x, double y, double z)
		{
		}

		public void SetVelocity(double x, double y, double z)
		{
		}

		[FieldProperty]
		public double SpeedOfSound
		{
			get {
				return 0;
			}
			set {
			}
		}
	}
}
