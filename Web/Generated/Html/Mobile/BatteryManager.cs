using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class BatteryManager : EventTarget {
		internal BatteryManager() {
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
	}
}
