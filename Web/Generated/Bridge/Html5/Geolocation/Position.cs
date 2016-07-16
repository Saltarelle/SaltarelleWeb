namespace Bridge.Html5.Geolocation
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class Position
	{
		internal Position()
		{
		}

		[FieldProperty]
		public Coordinates Coords
		{
			get {
				return default(Coordinates);
			}
		}

		[FieldProperty]
		public long Timestamp
		{
			get {
				return 0;
			}
		}
	}
}
