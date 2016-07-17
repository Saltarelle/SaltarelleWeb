namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class PopStateEvent : Event
	{
		internal extern PopStateEvent();

		public extern PopStateEvent(string type);

		public extern PopStateEvent(string type, PopStateEventInit eventInitDict);

		public extern void InitPopStateEvent(string type, bool canBubble, bool cancelable, object state);

		public readonly object State;
	}
}
