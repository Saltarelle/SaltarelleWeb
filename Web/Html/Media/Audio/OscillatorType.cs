// OscillatorType.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[NamedValues]
	[IgnoreNamespace, Imported]
	public enum OscillatorType {
		[ScriptName("sine")] Sine,

		[ScriptName("square")] Square,

		[ScriptName("sawtooth")] Sawtooth,

		[ScriptName("triangle")] Triangle,

		[ScriptName("custom")] Custom
	}
}