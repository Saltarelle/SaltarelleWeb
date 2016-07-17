namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class AnimationEvent : Event
	{
		internal extern AnimationEvent();

		public extern AnimationEvent(string type);

		public extern AnimationEvent(string type, AnimationEventInit eventInitDict);

		public readonly string AnimationName;

		public readonly double ElapsedTime;

		public readonly string PseudoElement;
	}
}
