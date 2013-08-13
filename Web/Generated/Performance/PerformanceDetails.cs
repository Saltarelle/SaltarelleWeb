using System.Runtime.CompilerServices;

namespace System.Performance {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Performance")]
	public partial class PerformanceDetails {
		internal PerformanceDetails() {
		}

		[IntrinsicProperty]
		public PerformanceNavigation Navigation {
			get {
				return default(PerformanceNavigation);
			}
		}

		public double Now() {
			return 0;
		}

		[IntrinsicProperty]
		public PerformanceTiming Timing {
			get {
				return default(PerformanceTiming);
			}
		}
	}
}
