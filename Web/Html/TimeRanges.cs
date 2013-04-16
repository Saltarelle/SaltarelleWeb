using System.Runtime.CompilerServices;

namespace System.Html {
	public class TimeRanges {
		private TimeRanges() {}

		[IntrinsicProperty]
		public int Length { get { return 0; } }

		public double Start(int index) { return 0; }
		public double End(int index) { return 0; }
	}
}