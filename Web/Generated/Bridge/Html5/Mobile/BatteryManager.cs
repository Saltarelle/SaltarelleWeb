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

		[FieldProperty]
		public extern bool Charging
		{
			get;
		}

		[FieldProperty]
		public extern double ChargingTime
		{
			get;
		}

		[FieldProperty]
		public extern double DischargingTime
		{
			get;
		}

		[FieldProperty]
		public extern double Level
		{
			get;
		}

		[FieldProperty, Name("onchargingchange")]
		public extern HtmlEventHandler OnChargingchange
		{
			get;
			set;
		}

		[FieldProperty, Name("onchargingtimechange")]
		public extern HtmlEventHandler OnChargingtimechange
		{
			get;
			set;
		}

		[FieldProperty, Name("ondischargingtimechange")]
		public extern HtmlEventHandler OnDischargingtimechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onlevelchange")]
		public extern HtmlEventHandler OnLevelchange
		{
			get;
			set;
		}

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
