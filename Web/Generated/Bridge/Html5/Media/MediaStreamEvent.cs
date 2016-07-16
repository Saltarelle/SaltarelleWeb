namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaStreamEvent : Event
	{
		internal MediaStreamEvent()
		{
		}

		public MediaStreamEvent(string type)
		{
		}

		public MediaStreamEvent(string type, MediaStreamEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public MediaStream Stream
		{
			get {
				return default(MediaStream);
			}
		}
	}
}
