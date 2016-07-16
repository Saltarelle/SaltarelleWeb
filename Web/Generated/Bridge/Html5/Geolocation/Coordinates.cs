namespace Bridge.Html5.Geolocation
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class Coordinates
	{
		internal extern Coordinates();

		[FieldProperty]
		public extern double Accuracy
		{
			get;
		}

		[FieldProperty]
		public extern double? Altitude
		{
			get;
		}

		[FieldProperty]
		public extern double? AltitudeAccuracy
		{
			get;
		}

		[FieldProperty]
		public extern double? Heading
		{
			get;
		}

		[FieldProperty]
		public extern double Latitude
		{
			get;
		}

		[FieldProperty]
		public extern double Longitude
		{
			get;
		}

		[FieldProperty]
		public extern double? Speed
		{
			get;
		}
	}
}
