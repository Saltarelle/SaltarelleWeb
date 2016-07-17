namespace Bridge.Html5.Geolocation
{
	[Namespace(false), External, Name("Object")]
	public partial class PositionError
	{
		internal extern PositionError();

		public readonly ushort Code;

		public readonly string Message;

		[Name("PERMISSION_DENIED")]
		public readonly ushort PERMISSION_DENIED;

		[Name("POSITION_UNAVAILABLE")]
		public readonly ushort POSITION_UNAVAILABLE;

		public readonly ushort TIMEOUT;
	}
}
