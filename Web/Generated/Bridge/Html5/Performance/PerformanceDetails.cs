namespace Bridge.Html5.Performance
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Performance")]
	public partial class PerformanceDetails
	{
		internal extern PerformanceDetails();

		[FieldProperty]
		public extern PerformanceNavigation Navigation
		{
			get;
		}

		public extern double Now();

		[FieldProperty]
		public extern PerformanceTiming Timing
		{
			get;
		}
	}
}
