namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioListener
	{
		internal extern AudioListener();

		public double DopplerFactor;

		public extern void SetOrientation(double x, double y, double z, double xUp, double yUp, double zUp);

		public extern void SetPosition(double x, double y, double z);

		public extern void SetVelocity(double x, double y, double z);

		public double SpeedOfSound;
	}
}
