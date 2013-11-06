using System.Runtime.CompilerServices;

namespace System.IO {
	[Imported, NamedValues]
	public enum FileReaderEvents {
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
		Progress
	}
}
