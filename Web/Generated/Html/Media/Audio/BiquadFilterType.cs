// BiquadFilterType.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[Imported, NamedValues]
	public enum BiquadFilterType {
		[ScriptName("0")]
		_0,
		[ScriptName("1")]
		_1,
		[ScriptName("2")]
		_2,
		[ScriptName("3")]
		_3,
		[ScriptName("4")]
		_4,
		[ScriptName("5")]
		_5,
		[ScriptName("6")]
		_6,
		[ScriptName("7")]
		_7,
		Lowpass,
		Highpass,
		Bandpass,
		Lowshelf,
		Highshelf,
		Peaking,
		Notch,
		Allpass,
	}
}
