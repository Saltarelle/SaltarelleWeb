// ChannelCountMode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[Imported, NamedValues]
	public enum ChannelCountMode {
		Max,
		[ScriptName("clamped-max")]
		ClampedMax,
		Explicit,
	}
}
