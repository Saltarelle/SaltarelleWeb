namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaError
	{
		internal MediaError()
		{
		}

		[FieldProperty]
		public MediaErrorCode Code
		{
			get {
				return default(MediaErrorCode);
			}
		}

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
