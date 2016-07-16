namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CommandEvent : Event
	{
		internal extern CommandEvent();

		[FieldProperty]
		public extern string Command
		{
			get;
		}

		public extern void InitCommandEvent(string type, bool canBubble, bool cancelable, string command);
	}
}
