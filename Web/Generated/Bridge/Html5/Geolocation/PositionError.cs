namespace Bridge.Html5.Geolocation
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class PositionError
	{
		internal PositionError()
		{
		}

		[FieldProperty]
		public ushort Code
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string Message
		{
			get {
				return null;
			}
		}

		[FieldProperty, Name("PERMISSION_DENIED")]
		public ushort PERMISSION_DENIED
		{
			get {
				return 0;
			}
		}

		[FieldProperty, Name("POSITION_UNAVAILABLE")]
		public ushort POSITION_UNAVAILABLE
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public ushort TIMEOUT
		{
			get {
				return 0;
			}
		}
	}
}
