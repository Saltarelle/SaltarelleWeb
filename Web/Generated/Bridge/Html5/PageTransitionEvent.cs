namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class PageTransitionEvent : Event
	{
		internal extern PageTransitionEvent();

		public extern PageTransitionEvent(string type);

		public extern PageTransitionEvent(string type, PageTransitionEventInit eventInitDict);

		public extern void InitPageTransitionEvent(string type, bool canBubble, bool cancelable, bool persisted);

		public readonly bool Persisted;
	}
}
