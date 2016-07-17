using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace(false), External]
	public partial class AudioParam
	{
		internal extern AudioParam();

		public extern void CancelScheduledValues(double startTime);

		public readonly double DefaultValue;

		public extern void ExponentialRampToValueAtTime(double value, double endTime);

		public extern void LinearRampToValueAtTime(double value, double endTime);

		public extern void SetTargetAtTime(double target, double startTime, double timeConstant);

		public extern void SetTargetValueAtTime(double target, double startTime, double timeConstant);

		public extern void SetValueAtTime(double value, double startTime);

		public extern void SetValueCurveAtTime(Float32Array values, double startTime, double duration);

		public double Value;
	}
}
