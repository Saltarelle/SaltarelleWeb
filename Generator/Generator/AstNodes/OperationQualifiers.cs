using System;

namespace Generator.AstNodes {
	[Flags]
	public enum OperationQualifiers {
		None         =  0,
		Stringifier  =  1,
		Static       =  2,
		LegacyCaller =  4,
		Getter       =  8,
		Setter       = 16,
		Creator      = 32,
		Deleter      = 64,

		Accessor = Getter | Setter | Creator | Deleter,
	}
}