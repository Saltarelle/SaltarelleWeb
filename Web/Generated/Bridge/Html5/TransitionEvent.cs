namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TransitionEvent : Event
	{
		internal TransitionEvent()
		{
		}

		public TransitionEvent(string type)
		{
		}

		public TransitionEvent(string type, TransitionEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public double ElapsedTime
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string PropertyName
		{
			get {
				return null;
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
