using System.Runtime.CompilerServices;

namespace System.IO {
	[Imported, NamedValues]
	public enum FileReaderEvents {
		[ScriptName("onloadstart")]
		Loadstart,
		[ScriptName("onprogress")]
		Progress,
		[ScriptName("onload")]
		Load,
		[ScriptName("onabort")]
		Abort,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onloadend")]
		Loadend
	}
}
