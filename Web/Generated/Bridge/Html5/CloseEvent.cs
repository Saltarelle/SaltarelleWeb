namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class CloseEvent : Event
	{
		internal extern CloseEvent();

		public extern CloseEvent(string type);

		public extern CloseEvent(string type, CloseEventInit eventInitDict);

		public readonly ushort Code;

		public extern void InitCloseEvent(string type, bool canBubble, bool cancelable, bool wasClean, ushort code, string reason);

		public readonly string Reason;

		public readonly bool WasClean;
	}
}
