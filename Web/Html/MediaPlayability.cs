// MediaPlayability.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[NamedValues, Imported]
	public enum MediaPlayability {
		Probably,
		Maybe,
		[ScriptName("")] No,
	}
}