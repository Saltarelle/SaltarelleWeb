namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CustomEvent : Event
	{
		internal extern CustomEvent();

		public extern CustomEvent(string type);

		public extern CustomEvent(string type, CustomEventInit eventInitDict);

		[FieldProperty]
		public extern object Detail
		{
			get;
		}

		public extern void InitCustomEvent(string type, bool canBubble, bool cancelable, object detail);
	}
}
