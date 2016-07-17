namespace Bridge.Html5.Performance
{
	[Namespace("false"), External, Name("Performance")]
	public partial class PerformanceDetails
	{
		internal extern PerformanceDetails();

		public readonly PerformanceNavigation Navigation;

		public extern double Now();

		public readonly PerformanceTiming Timing;
	}
}
