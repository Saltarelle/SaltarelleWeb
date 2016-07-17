namespace Bridge.Html5.Geolocation
{
	[Namespace(false), External, Name("Object")]
	public partial class Coordinates
	{
		internal extern Coordinates();

		public readonly double Accuracy;

		public readonly double? Altitude;

		public readonly double? AltitudeAccuracy;

		public readonly double? Heading;

		public readonly double Latitude;

		public readonly double Longitude;

		public readonly double? Speed;
	}
}
