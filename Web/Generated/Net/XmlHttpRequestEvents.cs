using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported, NamedValues]
	public enum XmlHttpRequestEvents {
		Abort,
		Error,
		Load,
		Loadend,
		Loadstart,
		Progress,
		Readystatechange,
		Timeout
	}
}
