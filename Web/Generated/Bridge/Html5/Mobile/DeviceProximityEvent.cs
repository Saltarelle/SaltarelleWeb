namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DeviceProximityEvent : Event
	{
		internal extern DeviceProximityEvent();

		public extern DeviceProximityEvent(string type);

		public extern DeviceProximityEvent(string type, DeviceProximityEventInit eventInitDict);

		[FieldProperty]
		public extern double Max
		{
			get;
		}

		[FieldProperty]
		public extern double Min
		{
			get;
		}

		[FieldProperty]
		public extern double Value
		{
			get;
		}
	}
}
