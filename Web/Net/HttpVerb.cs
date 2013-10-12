using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported, NamedValues]
	public enum HttpVerb {
		[ScriptName("GET")] Get = 0,
		[ScriptName("POST")] Post = 1,
		[ScriptName("PUT")] Put = 2,
		[ScriptName("DELETE")] Delete = 3,
		[ScriptName("HEAD")] Head = 4
	}
}