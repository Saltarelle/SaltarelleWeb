namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AnimationEvent : Event
	{
		internal AnimationEvent()
		{
		}

		public AnimationEvent(string type)
		{
		}

		public AnimationEvent(string type, AnimationEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public string AnimationName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public double ElapsedTime
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string PseudoElement
		{
			get {
				return null;
			}
		}
	}
}
