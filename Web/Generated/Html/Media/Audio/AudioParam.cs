using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AudioParam {
		internal AudioParam() {
		}

		public void CancelScheduledValues(double startTime) {
		}

		[IntrinsicProperty]
		public double DefaultValue {
			get {
				return 0;
			}
		}

		public void ExponentialRampToValueAtTime(double value, double endTime) {
		}

		public void LinearRampToValueAtTime(double value, double endTime) {
		}

		public void SetTargetAtTime(double target, double startTime, double timeConstant) {
		}

		public void SetTargetValueAtTime(double target, double startTime, double timeConstant) {
		}

		public void SetValueAtTime(double value, double startTime) {
		}

		public void SetValueCurveAtTime(Float32Array values, double startTime, double duration) {
		}

		[IntrinsicProperty]
		public double Value {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
