namespace Bridge.Html5.Geolocation
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class Position
	{
		internal extern Position();

		[FieldProperty]
		public extern Coordinates Coords
		{
			get;
		}

		[FieldProperty]
		public extern long Timestamp
		{
			get;
		}
	}
}
