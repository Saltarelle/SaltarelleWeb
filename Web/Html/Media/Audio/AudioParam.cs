// AudioParam.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	/// <summary>
	/// AudioParam controls an individual aspect of an AudioNode's functioning (e.g., volume).
	/// </summary>
	/// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#AudioParam</reference>
	[IgnoreNamespace, Imported]
	public class AudioParam {
		private AudioParam() {
		}

		/// <summary>
		/// Cancels all scheduled parameter changes with times greater than or equal to startTime.
		/// </summary>
		/// <param name="startTime">The startTime parameter is the starting time at and after which 
		/// any previously scheduled parameter changes will be cancelled. It is a time in the 
		/// same time coordinate system as AudioContext.currentTime.</param>
		public void CancelScheduledValues(double startTime) {
		}

		/// <summary>
		/// The final value controlling the audio DSP.
		/// </summary>
		[IntrinsicProperty]
		public float ComputedValue { get; private set; }

		/// <summary>
		/// Initial value for the value attribute.
		/// </summary>
		[IntrinsicProperty]
		public float DefaultValue { get; private set; }

		/// <summary>
		/// Schedules an exponential continuous change in parameter value from the previous 
		/// scheduled parameter value to the given value. Parameters representing filter 
		/// frequencies and playback rate are best changed exponentially because of the 
		/// way humans perceive sound.
		/// </summary>
		/// <param name="value">The value parameter is the value the parameter will 
		/// exponentially ramp to at the given time. An exception will be thrown if this 
		/// value is less than or equal to 0, or if the value at the time of the previous 
		/// event is less than or equal to 0.</param>
		/// <param name="endTime">The endTime parameter is the time in the same time 
		/// coordinate system as AudioContext.currentTime.</param>
		public void ExponentialRampToValueAtTime(float value, double endTime) {
		}

		/// <summary>
		/// Schedules a linear continuous change in parameter value from the previous 
		/// scheduled parameter value to the given value.
		/// </summary>
		/// <param name="value">The value parameter is the value the parameter will
		/// linearly ramp to at the given time.</param>
		/// <param name="endTime">The endTime parameter is the time in the same time
		/// coordinate system as AudioContext.currentTime.</param>
		public void LinearRampToValueAtTime(float value, double endTime) {
		}

		/// <summary>
		/// Nominal maximum value. This attribute is informational and value may be set 
		/// higher than this value.
		/// </summary>
		[IntrinsicProperty]
		public float MaxValue { get; private set; }

		/// <summary>
		/// Nominal minimum value. This attribute is informational and value may be set lower 
		/// than this value.
		/// </summary>
		[IntrinsicProperty]
		public float MinValue { get; private set; }

		/// <summary>
		/// Start exponentially approaching the target value at the given time with a rate 
		/// having the given time constant. Among other uses, this is useful for implementing 
		/// the "decay" and "release" portions of an ADSR envelope. Please note that the parameter 
		/// value does not immediately change to the target value at the given time, but instead 
		/// gradually changes to the target value.
		/// </summary>
		/// <param name="target">The target parameter is the value the parameter will start 
		/// changing to at the given time.</param>
		/// <param name="startTime">The startTime parameter is the time in the same time 
		/// coordinate system as AudioContext.currentTime.</param>
		/// <param name="timeConstant">The timeConstant parameter is the time-constant value of 
		/// first-order filter (exponential) approach to the target value. The larger this value 
		/// is, the slower the transition will be.</param>
		public void SetTargetAtTime(float target, double startTime, double timeConstant) {
		}

		/// <summary>
		/// Schedules a parameter value change at the given time.
		/// </summary>
		/// <param name="value">The value parameter is the value the parameter will 
		/// change to at the given time.</param>
		/// <param name="startTime">The startTime parameter is the time in the same time
		/// coordinate system as AudioContext.currentTime.</param>
		public void SetValueAtTime(float value, double startTime) {
		}

		/// <summary>
		/// Sets an array of arbitrary parameter values starting at the given time for the given 
		/// duration. The number of values will be scaled to fit into the desired duration.
		/// </summary>
		/// <param name="values">The values parameter is a Float32Array representing a parameter value 
		/// curve. These values will apply starting at the given time and lasting for the 
		/// given duration.</param>
		/// <param name="startTime">The startTime parameter is the time in the same time coordinate 
		/// system as AudioContext.currentTime</param>
		/// <param name="duration">The duration parameter is the amount of time in seconds (after 
		/// the time parameter) where values will be calculated according to the values parameter.</param>
		public void SetValueCurveAtTime(Float32Array values, double startTime, double duration) {
		}

		/// <summary>
		/// The parameter's floating-point value. This attribute is initialized to the defaultValue. If 
		/// a value is set outside the allowable range described by minValue and maxValue no exception is 
		/// thrown, because these limits are just nominal and may be exceeded. If a value is set during 
		/// a time when there are any automation events scheduled then it will be ignored and no 
		/// exception will be thrown.
		/// </summary>
		[IntrinsicProperty]
		public float Value { get; set; }
	}
}