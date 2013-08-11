// AudioParam.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

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
		public float DefaultValue {
			get { return 0; }
		}

		public void ExponentialRampToValueAtTime(float value, double endTime) {
		}

		public void LinearRampToValueAtTime(float value, double endTime) {
		}

		public void SetTargetAtTime(float target, double startTime, double timeConstant) {
		}

		public void SetTargetValueAtTime(float target, double startTime, double timeConstant) {
		}

		public void SetValueAtTime(float value, double startTime) {
		}

		public void SetValueCurveAtTime(Float32Array values, double startTime, double duration) {
		}

		[IntrinsicProperty]
		public float Value {
			get { return 0; }
			set { }
		}
	}
}
