using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[Imported, NamedValues]
	public enum ChannelCountMode {
		Max,
		[ScriptName("clamped-max")]
		ClampedMax,
		Explicit
	}
}
