using System.Runtime.CompilerServices;

namespace System.IO {
	[Imported, NamedValues]
	public enum FileReaderEvents {
		Abort,
		Error,
		Load,
		Loadend,
		Loadstart,
		Progress
	}
}
