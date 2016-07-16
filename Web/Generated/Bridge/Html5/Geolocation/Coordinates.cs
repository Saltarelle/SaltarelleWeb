namespace Bridge.Html5.Geolocation
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class Coordinates
	{
		internal Coordinates()
		{
		}

		[FieldProperty]
		public double Accuracy
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double? Altitude
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public double? AltitudeAccuracy
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public double? Heading
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public double Latitude
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double Longitude
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double? Speed
		{
			get {
				return null;
			}
		}
	}
}
