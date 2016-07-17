namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class BatteryManager : EventTarget
	{
		internal extern BatteryManager();

		public extern void AddEventListener(BatteryManagerEvents type, Action listener);

		public extern void AddEventListener(BatteryManagerEvents type, Action listener, bool capture);

		public extern void AddEventListener(BatteryManagerEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(BatteryManagerEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener);

		public extern void AddEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture);

		public extern void AddEventListener(BatteryManagerEvents type, IEventListener listener);

		public extern void AddEventListener(BatteryManagerEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture);

		public readonly bool Charging;

		public readonly double ChargingTime;

		public readonly double DischargingTime;

		public readonly double Level;

		[Name("onchargingchange")]
		public HtmlEventHandler OnChargingchange;

		[Name("onchargingtimechange")]
		public HtmlEventHandler OnChargingtimechange;

		[Name("ondischargingtimechange")]
		public HtmlEventHandler OnDischargingtimechange;

		[Name("onlevelchange")]
		public HtmlEventHandler OnLevelchange;

		public extern void RemoveEventListener(BatteryManagerEvents type, Action listener);

		public extern void RemoveEventListener(BatteryManagerEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener);

		public extern void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture);

		public extern void RemoveEventListener(BatteryManagerEvents type, IEventListener listener);

		public extern void RemoveEventListener(BatteryManagerEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture);
	}
}
