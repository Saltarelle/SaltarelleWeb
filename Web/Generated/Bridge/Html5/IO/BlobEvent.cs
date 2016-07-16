namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class BlobEvent : Event
	{
		internal extern BlobEvent();

		public extern BlobEvent(string type);

		public extern BlobEvent(string type, BlobEventInit eventInitDict);

		[FieldProperty]
		public extern Blob Data
		{
			get;
		}
	}
}
