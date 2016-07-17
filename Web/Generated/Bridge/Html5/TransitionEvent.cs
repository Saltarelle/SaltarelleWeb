namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class TransitionEvent : Event
	{
		internal extern TransitionEvent();

		public extern TransitionEvent(string type);

		public extern TransitionEvent(string type, TransitionEventInit eventInitDict);

		public readonly double ElapsedTime;

		public readonly string PropertyName;

		public readonly string PseudoElement;
	}
}
