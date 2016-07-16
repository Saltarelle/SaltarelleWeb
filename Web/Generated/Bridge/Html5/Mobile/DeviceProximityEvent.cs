namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DeviceProximityEvent : Event
	{
		internal DeviceProximityEvent()
		{
		}

		public DeviceProximityEvent(string type)
		{
		}

		public DeviceProximityEvent(string type, DeviceProximityEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public double Max
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double Min
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double Value
		{
			get {
				return 0;
			}
		}
	}
}
