namespace Bridge.Html5.Geolocation
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class PositionError
	{
		internal extern PositionError();

		[FieldProperty]
		public extern ushort Code
		{
			get;
		}

		[FieldProperty]
		public extern string Message
		{
			get;
		}

		[FieldProperty, Name("PERMISSION_DENIED")]
		public extern ushort PERMISSION_DENIED
		{
			get;
		}

		[FieldProperty, Name("POSITION_UNAVAILABLE")]
		public extern ushort POSITION_UNAVAILABLE
		{
			get;
		}

		[FieldProperty]
		public extern ushort TIMEOUT
		{
			get;
		}
	}
}
