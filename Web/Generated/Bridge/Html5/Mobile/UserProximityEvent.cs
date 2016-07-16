namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class UserProximityEvent : Event
	{
		internal extern UserProximityEvent();

		public extern UserProximityEvent(string type);

		public extern UserProximityEvent(string type, UserProximityEventInit eventInitDict);

		[FieldProperty]
		public extern bool Near
		{
			get;
		}
	}
}
