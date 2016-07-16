namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DeviceLightEvent : Event
	{
		internal extern DeviceLightEvent();

		public extern DeviceLightEvent(string type);

		public extern DeviceLightEvent(string type, DeviceLightEventInit eventInitDict);

		[FieldProperty]
		public extern double Value
		{
			get;
		}
	}
}
