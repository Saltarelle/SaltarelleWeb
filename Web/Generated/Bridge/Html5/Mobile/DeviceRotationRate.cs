namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class DeviceRotationRate
	{
		internal extern DeviceRotationRate();

		[FieldProperty]
		public extern double? Alpha
		{
			get;
		}

		[FieldProperty]
		public extern double? Beta
		{
			get;
		}

		[FieldProperty]
		public extern double? Gamma
		{
			get;
		}
	}
}
