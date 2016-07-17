namespace Bridge.Html5.Media
{
	[Namespace(false), External]
	public partial class MediaError
	{
		internal extern MediaError();

		public readonly MediaErrorCode Code;

		[Name("MEDIA_ERR_ABORTED")]
		public const ushort MEDIA_ERR_ABORTED = 1;

		[Name("MEDIA_ERR_DECODE")]
		public const ushort MEDIA_ERR_DECODE = 3;

		[Name("MEDIA_ERR_NETWORK")]
		public const ushort MEDIA_ERR_NETWORK = 2;

		[Name("MEDIA_ERR_SRC_NOT_SUPPORTED")]
		public const ushort MEDIA_ERR_SRC_NOT_SUPPORTED = 4;
	}
}
