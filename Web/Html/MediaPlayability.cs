using System.Runtime.CompilerServices;

namespace System.Html {
	[NamedValues, Imported]
	public enum MediaPlayability {
		Probably,
		Maybe,
		[ScriptName("")] No,
	}
}