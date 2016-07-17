namespace Bridge.Html5.Geolocation
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class Position
	{
		internal extern Position();

		public readonly Coordinates Coords;

		public readonly long Timestamp;
	}
}
