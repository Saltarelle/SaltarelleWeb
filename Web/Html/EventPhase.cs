using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported]
	public enum EventPhase {
		None           = 0,
		CapturingPhase = 1,
		AtTarget       = 2,
		BubblingPhase  = 3,
	}
}