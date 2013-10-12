using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[Imported, NamedValues]
	public enum MediaPlayability {
		Probably,
		Maybe,
		[ScriptName("")] No,
	}
}