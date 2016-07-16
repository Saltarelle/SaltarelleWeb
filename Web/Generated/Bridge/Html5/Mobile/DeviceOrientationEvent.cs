namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DeviceOrientationEvent : Event
	{
		internal extern DeviceOrientationEvent();

		public extern DeviceOrientationEvent(string type);

		public extern DeviceOrientationEvent(string type, DeviceOrientationEventInit eventInitDict);

		[FieldProperty]
		public extern bool Absolute
		{
			get;
		}

		[FieldProperty]
		public extern double Alpha
		{
			get;
		}

		[FieldProperty]
		public extern double Beta
		{
			get;
		}

		[FieldProperty]
		public extern double Gamma
		{
			get;
		}

		public extern void InitDeviceOrientationEvent(string type, bool canBubble, bool cancelable, double alpha, double beta, double gamma, bool absolute);
	}
}
