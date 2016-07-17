namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class TimeEvent : Event
	{
		internal extern TimeEvent();

		public readonly int Detail;

		public extern void InitTimeEvent(string aType, WindowInstance aView, int aDetail);

		public readonly WindowInstance View;
	}
}
