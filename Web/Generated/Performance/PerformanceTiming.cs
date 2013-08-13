using System.Runtime.CompilerServices;

namespace System.Performance {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class PerformanceTiming {
		internal PerformanceTiming() {
		}

		[IntrinsicProperty]
		public ulong ConnectEnd {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong ConnectStart {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong DomainLookupEnd {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong DomainLookupStart {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong DomComplete {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong DomContentLoadedEventEnd {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong DomContentLoadedEventStart {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong DomInteractive {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong DomLoading {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong FetchStart {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong LoadEventEnd {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong LoadEventStart {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong NavigationStart {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong RedirectEnd {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong RedirectStart {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong RequestStart {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong ResponseEnd {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong ResponseStart {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong UnloadEventEnd {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public ulong UnloadEventStart {
			get {
				return 0;
			}
		}
	}
}
