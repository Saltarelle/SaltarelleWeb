using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[Imported, NamedValues]
	public enum TextTrackListEvents {
		[ScriptName("onaddtrack")]
		Addtrack,
		[ScriptName("onchange")]
		Change,
		[ScriptName("onremovetrack")]
		Removetrack
	}
}
