namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class DeviceAcceleration
	{
		internal extern DeviceAcceleration();

		[FieldProperty]
		public extern double? X
		{
			get;
		}

		[FieldProperty]
		public extern double? Y
		{
			get;
		}

		[FieldProperty]
		public extern double? Z
		{
			get;
		}
	}
}
