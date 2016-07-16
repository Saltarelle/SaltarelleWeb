namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DeviceLightEvent : Event
	{
		internal DeviceLightEvent()
		{
		}

		public DeviceLightEvent(string type)
		{
		}

		public DeviceLightEvent(string type, DeviceLightEventInit eventInitDict)
		{
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
