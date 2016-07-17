namespace Bridge.Html5.Mobile
{
	[Namespace(false), External]
	public partial class DeviceProximityEvent : Event
	{
		internal extern DeviceProximityEvent();

		public extern DeviceProximityEvent(string type);

		public extern DeviceProximityEvent(string type, DeviceProximityEventInit eventInitDict);

		public readonly double Max;

		public readonly double Min;

		public readonly double Value;
	}
}
