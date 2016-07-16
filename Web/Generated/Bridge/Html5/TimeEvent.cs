namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TimeEvent : Event
	{
		internal TimeEvent()
		{
		}

		[FieldProperty]
		public int Detail
		{
			get {
				return 0;
			}
		}

		public void InitTimeEvent(string aType, WindowInstance aView, int aDetail)
		{
		}

		[FieldProperty]
		public WindowInstance View
		{
			get {
				return default(WindowInstance);
			}
		}
	}
}
