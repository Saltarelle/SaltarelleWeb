using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported, NamedValues]
	public enum XmlHttpRequestUploadEvents {
		[ScriptName("onloadstart")]
		Loadstart,
		[ScriptName("onprogress")]
		Progress,
		[ScriptName("onabort")]
		Abort,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onload")]
		Load,
		[ScriptName("ontimeout")]
		Timeout,
		[ScriptName("onloadend")]
		Loadend
	}
}
