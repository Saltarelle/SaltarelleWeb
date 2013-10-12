using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[Imported, NamedValues]
	public enum BatteryManagerEvents {
		[ScriptName("onchargingchange")]
		Chargingchange,
		[ScriptName("onchargingtimechange")]
		Chargingtimechange,
		[ScriptName("ondischargingtimechange")]
		Dischargingtimechange,
		[ScriptName("onlevelchange")]
		Levelchange
	}
}
