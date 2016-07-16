namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ClipboardEvent : Event
	{
		internal ClipboardEvent()
		{
		}

		public ClipboardEvent(string type)
		{
		}

		public ClipboardEvent(string type, ClipboardEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public DataTransfer ClipboardData
		{
			get {
				return default(DataTransfer);
			}
		}
	}
}
