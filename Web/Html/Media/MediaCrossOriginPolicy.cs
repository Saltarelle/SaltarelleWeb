using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[Imported, NamedValues]
	public enum MediaCrossOriginPolicy {
		Anonymous,
		[ScriptName("use-credentials")] UseCredentials,
	}
}