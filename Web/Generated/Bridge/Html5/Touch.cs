namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Touch
	{
		internal extern Touch();

		[FieldProperty]
		public extern int ClientX
		{
			get;
		}

		[FieldProperty]
		public extern int ClientY
		{
			get;
		}

		[FieldProperty]
		public extern double Force
		{
			get;
		}

		[FieldProperty]
		public extern int Identifier
		{
			get;
		}

		[FieldProperty]
		public extern int PageX
		{
			get;
		}

		[FieldProperty]
		public extern int PageY
		{
			get;
		}

		[FieldProperty]
		public extern int RadiusX
		{
			get;
		}

		[FieldProperty]
		public extern int RadiusY
		{
			get;
		}

		[FieldProperty]
		public extern double RotationAngle
		{
			get;
		}

		[FieldProperty]
		public extern int ScreenX
		{
			get;
		}

		[FieldProperty]
		public extern int ScreenY
		{
			get;
		}

		[FieldProperty]
		public extern EventTarget Target
		{
			get;
		}
	}
}
