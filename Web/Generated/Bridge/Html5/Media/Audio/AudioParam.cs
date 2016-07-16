using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioParam
	{
		internal AudioParam()
		{
		}

		public void CancelScheduledValues(double startTime)
		{
		}

		[FieldProperty]
		public double DefaultValue
		{
			get {
				return 0;
			}
		}

		public void ExponentialRampToValueAtTime(double value, double endTime)
		{
		}

		public void LinearRampToValueAtTime(double value, double endTime)
		{
		}

		public void SetTargetAtTime(double target, double startTime, double timeConstant)
		{
		}

		public void SetTargetValueAtTime(double target, double startTime, double timeConstant)
		{
		}

		public void SetValueAtTime(double value, double startTime)
		{
		}

		public void SetValueCurveAtTime(Float32Array values, double startTime, double duration)
		{
		}

		[FieldProperty]
		public double Value
		{
			get {
				return 0;
			}
			set {
			}
		}
	}
}
