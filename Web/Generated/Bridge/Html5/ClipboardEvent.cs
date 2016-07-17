namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ClipboardEvent : Event
	{
		internal extern ClipboardEvent();

		public extern ClipboardEvent(string type);

		public extern ClipboardEvent(string type, ClipboardEventInit eventInitDict);

		public readonly DataTransfer ClipboardData;
	}
}
