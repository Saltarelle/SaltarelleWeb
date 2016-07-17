namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class CommandEvent : Event
	{
		internal extern CommandEvent();

		public readonly string Command;

		public extern void InitCommandEvent(string type, bool canBubble, bool cancelable, string command);
	}
}
