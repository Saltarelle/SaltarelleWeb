// VisualTransition.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Filters {
	[IgnoreNamespace]
	[Imported]
	public sealed class VisualTransition : VisualFilter {
		private VisualTransition() {
		}

		public void Apply() {
		}

		[IntrinsicProperty]
		public double Duration {
			get { return 0f; }
			set { }
		}

		[IntrinsicProperty]
		public int Percent {
			get { return 0; }
		}

		public void Play() {
		}

		[IntrinsicProperty]
		public VisualTransitionState Status {
			get { return VisualTransitionState.Stopped; }
		}

		public void Stop() {
		}
	}
}