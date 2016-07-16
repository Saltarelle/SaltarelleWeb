namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class UserProximityEvent : Event
	{
		internal UserProximityEvent()
		{
		}

		public UserProximityEvent(string type)
		{
		}

		public UserProximityEvent(string type, UserProximityEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public bool Near
		{
			get {
				return false;
			}
		}
	}
}
