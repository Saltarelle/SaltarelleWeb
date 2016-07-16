namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DeviceOrientationEvent : Event
	{
		internal DeviceOrientationEvent()
		{
		}

		public DeviceOrientationEvent(string type)
		{
		}

		public DeviceOrientationEvent(string type, DeviceOrientationEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public bool Absolute
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public double Alpha
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double Beta
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double Gamma
		{
			get {
				return 0;
			}
		}

		public void InitDeviceOrientationEvent(string type, bool canBubble, bool cancelable, double alpha, double beta, double gamma, bool absolute)
		{
		}
	}
}
