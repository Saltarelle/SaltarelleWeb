using System.Runtime.CompilerServices;

namespace System.Html {
	[NamedValues, Imported]
	public enum MediaCrossOriginPolicy {
		Anonymous,
		[ScriptName("use-credentials")] UseCredentials,
	}
}