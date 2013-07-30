using System;

namespace Generator.AstNodes {
	[Flags]
	public enum OperationQualifiers {
		None         =  0,
		Stringifier  =  1,
		Static       =  2,
		Getter       =  4,
		Setter       =  8,
		Creator      = 16,
		Deleter      = 32,
		LegacyCaller = 64,
	}
}