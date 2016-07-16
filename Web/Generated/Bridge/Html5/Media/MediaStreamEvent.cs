namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaStreamEvent : Event
	{
		internal extern MediaStreamEvent();

		public extern MediaStreamEvent(string type);

		public extern MediaStreamEvent(string type, MediaStreamEventInit eventInitDict);

		[FieldProperty]
		public extern MediaStream Stream
		{
			get;
		}
	}
}
