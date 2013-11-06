using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported, NamedValues]
	public enum XmlHttpRequestUploadEvents {
		[ScriptName("onabort")]
		Abort,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onload")]
		Load,
		[ScriptName("onloadend")]
		Loadend,
		[ScriptName("onloadstart")]
		Loadstart,
		[ScriptName("onprogress")]
		Progress,
		[ScriptName("ontimeout")]
		Timeout
	}
}
