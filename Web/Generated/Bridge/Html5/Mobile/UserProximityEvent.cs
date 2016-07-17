namespace Bridge.Html5.Mobile
{
	[Namespace(false), External]
	public partial class UserProximityEvent : Event
	{
		internal extern UserProximityEvent();

		public extern UserProximityEvent(string type);

		public extern UserProximityEvent(string type, UserProximityEventInit eventInitDict);

		public readonly bool Near;
	}
}
