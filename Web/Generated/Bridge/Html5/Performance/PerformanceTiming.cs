namespace Bridge.Html5.Performance
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PerformanceTiming
	{
		internal extern PerformanceTiming();

		[FieldProperty]
		public extern ulong ConnectEnd
		{
			get;
		}

		[FieldProperty]
		public extern ulong ConnectStart
		{
			get;
		}

		[FieldProperty]
		public extern ulong DomainLookupEnd
		{
			get;
		}

		[FieldProperty]
		public extern ulong DomainLookupStart
		{
			get;
		}

		[FieldProperty]
		public extern ulong DomComplete
		{
			get;
		}

		[FieldProperty]
		public extern ulong DomContentLoadedEventEnd
		{
			get;
		}

		[FieldProperty]
		public extern ulong DomContentLoadedEventStart
		{
			get;
		}

		[FieldProperty]
		public extern ulong DomInteractive
		{
			get;
		}

		[FieldProperty]
		public extern ulong DomLoading
		{
			get;
		}

		[FieldProperty]
		public extern ulong FetchStart
		{
			get;
		}

		[FieldProperty]
		public extern ulong LoadEventEnd
		{
			get;
		}

		[FieldProperty]
		public extern ulong LoadEventStart
		{
			get;
		}

		[FieldProperty]
		public extern ulong NavigationStart
		{
			get;
		}

		[FieldProperty]
		public extern ulong RedirectEnd
		{
			get;
		}

		[FieldProperty]
		public extern ulong RedirectStart
		{
			get;
		}

		[FieldProperty]
		public extern ulong RequestStart
		{
			get;
		}

		[FieldProperty]
		public extern ulong ResponseEnd
		{
			get;
		}

		[FieldProperty]
		public extern ulong ResponseStart
		{
			get;
		}

		[FieldProperty]
		public extern ulong UnloadEventEnd
		{
			get;
		}

		[FieldProperty]
		public extern ulong UnloadEventStart
		{
			get;
		}
	}
}
