namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class BlobEvent : Event
	{
		internal BlobEvent()
		{
		}

		public BlobEvent(string type)
		{
		}

		public BlobEvent(string type, BlobEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public Blob Data
		{
			get {
				return default(Blob);
			}
		}
	}
}
