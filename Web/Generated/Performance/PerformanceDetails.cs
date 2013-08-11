// PerformanceDetails.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Performance {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Performance")]
	public partial class PerformanceDetails {
		internal PerformanceDetails() {
		}

		[IntrinsicProperty]
		public PerformanceNavigation Navigation {
			get { return default(PerformanceNavigation); }
		}

		public double Now() {
			return 0;
		}

		[IntrinsicProperty]
		public PerformanceTiming Timing {
			get { return default(PerformanceTiming); }
		}
	}
}
