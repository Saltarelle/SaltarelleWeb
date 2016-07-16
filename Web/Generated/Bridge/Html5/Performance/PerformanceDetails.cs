namespace Bridge.Html5.Performance
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Performance")]
	public partial class PerformanceDetails
	{
		internal PerformanceDetails()
		{
		}

		[FieldProperty]
		public PerformanceNavigation Navigation
		{
			get {
				return default(PerformanceNavigation);
			}
		}

		public double Now()
		{
			return 0;
		}

		[FieldProperty]
		public PerformanceTiming Timing
		{
			get {
				return default(PerformanceTiming);
			}
		}
	}
}
