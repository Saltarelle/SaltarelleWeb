namespace Bridge.Html5.Performance
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PerformanceNavigation
	{
		internal PerformanceNavigation()
		{
		}

		[FieldProperty]
		public ushort RedirectCount
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public ushort Type
		{
			get {
				return 0;
			}
		}

		[Name("TYPE_BACK_FORWARD")]
		public const ushort TYPE_BACK_FORWARD = 2;

		[Name("TYPE_NAVIGATE")]
		public const ushort TYPE_NAVIGATE = 0;

		[Name("TYPE_RELOAD")]
		public const ushort TYPE_RELOAD = 1;

		[Name("TYPE_RESERVED")]
		public const ushort TYPE_RESERVED = 255;
	}
}
