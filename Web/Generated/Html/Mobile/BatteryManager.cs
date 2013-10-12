using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class BatteryManager : EventTarget {
		internal BatteryManager() {
		}

		public void AddEventListener(BatteryManagerEvents type, Action listener) {
		}

		public void AddEventListener(BatteryManagerEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(BatteryManagerEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(BatteryManagerEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener) {
		}

		public void AddEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture) {
		}

		public void AddEventListener(BatteryManagerEvents type, IEventListener listener) {
		}

		public void AddEventListener(BatteryManagerEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Charging {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public double ChargingTime {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public double DischargingTime {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public double Level {
			get {
				return 0;
			}
		}

		[IntrinsicProperty, ScriptName("onchargingchange")]
		public HtmlEventHandler OnChargingchange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onchargingtimechange")]
		public HtmlEventHandler OnChargingtimechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondischargingtimechange")]
		public HtmlEventHandler OnDischargingtimechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onlevelchange")]
		public HtmlEventHandler OnLevelchange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(BatteryManagerEvents type, Action listener) {
		}

		public void RemoveEventListener(BatteryManagerEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener) {
		}

		public void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture) {
		}

		public void RemoveEventListener(BatteryManagerEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(BatteryManagerEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture) {
		}
	}
}
