namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DeviceOrientationEvent : Event
	{
		internal extern DeviceOrientationEvent();

		public extern DeviceOrientationEvent(string type);

		public extern DeviceOrientationEvent(string type, DeviceOrientationEventInit eventInitDict);

		public readonly bool Absolute;

		public readonly double Alpha;

		public readonly double Beta;

		public readonly double Gamma;

		public extern void InitDeviceOrientationEvent(string type, bool canBubble, bool cancelable, double alpha, double beta, double gamma, bool absolute);
	}
}
