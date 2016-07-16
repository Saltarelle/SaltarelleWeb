namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AnimationEvent : Event
	{
		internal extern AnimationEvent();

		public extern AnimationEvent(string type);

		public extern AnimationEvent(string type, AnimationEventInit eventInitDict);

		[FieldProperty]
		public extern string AnimationName
		{
			get;
		}

		[FieldProperty]
		public extern double ElapsedTime
		{
			get;
		}

		[FieldProperty]
		public extern string PseudoElement
		{
			get;
		}
	}
}
