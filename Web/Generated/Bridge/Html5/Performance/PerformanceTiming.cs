namespace Bridge.Html5.Performance
{
	[Namespace("false"), External]
	public partial class PerformanceTiming
	{
		internal extern PerformanceTiming();

		public readonly ulong ConnectEnd;

		public readonly ulong ConnectStart;

		public readonly ulong DomainLookupEnd;

		public readonly ulong DomainLookupStart;

		public readonly ulong DomComplete;

		public readonly ulong DomContentLoadedEventEnd;

		public readonly ulong DomContentLoadedEventStart;

		public readonly ulong DomInteractive;

		public readonly ulong DomLoading;

		public readonly ulong FetchStart;

		public readonly ulong LoadEventEnd;

		public readonly ulong LoadEventStart;

		public readonly ulong NavigationStart;

		public readonly ulong RedirectEnd;

		public readonly ulong RedirectStart;

		public readonly ulong RequestStart;

		public readonly ulong ResponseEnd;

		public readonly ulong ResponseStart;

		public readonly ulong UnloadEventEnd;

		public readonly ulong UnloadEventStart;
	}
}
