namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class Touch
	{
		internal extern Touch();

		public readonly int ClientX;

		public readonly int ClientY;

		public readonly double Force;

		public readonly int Identifier;

		public readonly int PageX;

		public readonly int PageY;

		public readonly int RadiusX;

		public readonly int RadiusY;

		public readonly double RotationAngle;

		public readonly int ScreenX;

		public readonly int ScreenY;

		public readonly EventTarget Target;
	}
}
