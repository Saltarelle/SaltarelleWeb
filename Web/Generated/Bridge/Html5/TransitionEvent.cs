namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TransitionEvent : Event
	{
		internal extern TransitionEvent();

		public extern TransitionEvent(string type);

		public extern TransitionEvent(string type, TransitionEventInit eventInitDict);

		[FieldProperty]
		public extern double ElapsedTime
		{
			get;
		}

		[FieldProperty]
		public extern string PropertyName
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
