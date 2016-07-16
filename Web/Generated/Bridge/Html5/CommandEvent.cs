namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CommandEvent : Event
	{
		internal CommandEvent()
		{
		}

		[FieldProperty]
		public string Command
		{
			get {
				return null;
			}
		}

		public void InitCommandEvent(string type, bool canBubble, bool cancelable, string command)
		{
		}
	}
}
