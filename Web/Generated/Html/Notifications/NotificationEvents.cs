using System.Runtime.CompilerServices;

namespace System.Html.Notifications {
	[Imported, NamedValues]
	public enum NotificationEvents {
		[ScriptName("onclick")]
		Click,
		[ScriptName("onclose")]
		Close,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onshow")]
		Show
	}
}
