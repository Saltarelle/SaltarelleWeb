using System.Runtime.CompilerServices;

namespace System.Html.Notifications {
	[Imported, NamedValues]
	public enum NotificationEvents {
		[ScriptName("onclick")]
		Click,
		[ScriptName("onshow")]
		Show,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onclose")]
		Close
	}
}
