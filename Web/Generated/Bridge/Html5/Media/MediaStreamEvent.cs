namespace Bridge.Html5.Media
{
	[Namespace(false), External]
	public partial class MediaStreamEvent : Event
	{
		internal extern MediaStreamEvent();

		public extern MediaStreamEvent(string type);

		public extern MediaStreamEvent(string type, MediaStreamEventInit eventInitDict);

		public readonly MediaStream Stream;
	}
}
