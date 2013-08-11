// DocumentPosition.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Xml {
	[Imported]
	public enum DocumentPosition {
		Disconnected = 1,
		Preceding = 2,
		Following = 4,
		Contains = 8,
		ContainedBy = 16,
		ImplementationSpecific = 32,
	}
}
