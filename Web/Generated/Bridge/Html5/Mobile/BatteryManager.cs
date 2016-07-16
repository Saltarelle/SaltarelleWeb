namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class BatteryManager : EventTarget
	{
		internal BatteryManager()
		{
		}

		public void AddEventListener(BatteryManagerEvents type, Action listener)
		{
		}

		public void AddEventListener(BatteryManagerEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(BatteryManagerEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(BatteryManagerEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener)
		{
		}

		public void AddEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture)
		{
		}

		public void AddEventListener(BatteryManagerEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(BatteryManagerEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture)
		{
		}

		[FieldProperty]
		public bool Charging
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public double ChargingTime
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double DischargingTime
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double Level
		{
			get {
				return 0;
			}
		}

		[FieldProperty, Name("onchargingchange")]
		public HtmlEventHandler OnChargingchange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onchargingtimechange")]
		public HtmlEventHandler OnChargingtimechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondischargingtimechange")]
		public HtmlEventHandler OnDischargingtimechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onlevelchange")]
		public HtmlEventHandler OnLevelchange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(BatteryManagerEvents type, Action listener)
		{
		}

		public void RemoveEventListener(BatteryManagerEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener)
		{
		}

		public void RemoveEventListener(BatteryManagerEvents type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture)
		{
		}

		public void RemoveEventListener(BatteryManagerEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(BatteryManagerEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BatteryManager> listener, bool capture)
		{
		}
	}
}
