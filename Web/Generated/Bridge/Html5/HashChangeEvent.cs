namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class HashChangeEvent : Event
	{
		internal extern HashChangeEvent();

		public extern HashChangeEvent(string type);

		public extern HashChangeEvent(string type, HashChangeEventInit eventInitDict);

		public extern void InitHashChangeEvent(string type, bool canBubble, bool cancelable, string oldURL, string newURL);

		public readonly string NewURL;

		public readonly string OldURL;
	}
}
