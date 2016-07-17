namespace Bridge.Html5.IO
{
	[Namespace(false), External]
	public partial class BlobEvent : Event
	{
		internal extern BlobEvent();

		public extern BlobEvent(string type);

		public extern BlobEvent(string type, BlobEventInit eventInitDict);

		public readonly Blob Data;
	}
}
