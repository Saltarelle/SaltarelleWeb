namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PageTransitionEvent : Event
	{
		internal PageTransitionEvent()
		{
		}

		public PageTransitionEvent(string type)
		{
		}

		public PageTransitionEvent(string type, PageTransitionEventInit eventInitDict)
		{
		}

		public void InitPageTransitionEvent(string type, bool canBubble, bool cancelable, bool persisted)
		{
		}

		[FieldProperty]
		public bool Persisted
		{
			get {
				return false;
			}
		}
	}
}
