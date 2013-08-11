// OscillatorNodePlaybackState.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[NumericValues]
	[IgnoreNamespace, Imported]
	public enum OscillatorNodePlaybackState : ushort {
		UnscheduledState = 0,
		ScheduledState = 1,
		PlayingState = 2,
		FinishedState = 3
	}
}