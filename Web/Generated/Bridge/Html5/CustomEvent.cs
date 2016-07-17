namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CustomEvent : Event
	{
		internal extern CustomEvent();

		public extern CustomEvent(string type);

		public extern CustomEvent(string type, CustomEventInit eventInitDict);

		public readonly object Detail;

		public extern void InitCustomEvent(string type, bool canBubble, bool cancelable, object detail);
	}
}
