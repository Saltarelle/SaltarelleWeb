namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TimeEvent : Event
	{
		internal extern TimeEvent();

		[FieldProperty]
		public extern int Detail
		{
			get;
		}

		public extern void InitTimeEvent(string aType, WindowInstance aView, int aDetail);

		[FieldProperty]
		public extern WindowInstance View
		{
			get;
		}
	}
}
