namespace Bridge.Html5.Media.Recording
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class RecordErrorEvent : Event
	{
		internal extern RecordErrorEvent();

		public extern RecordErrorEvent(string type);

		public extern RecordErrorEvent(string type, RecordErrorEventInit eventInitDict);

		[FieldProperty]
		public extern string Name
		{
			get;
		}
	}
}
