using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaError {
		internal MediaError() {
		}

		[IntrinsicProperty]
		public MediaErrorCode Code {
			get { return default(MediaErrorCode); }
		}

		[ScriptName("MEDIA_ERR_ABORTED")]
		public const ushort MEDIA_ERR_ABORTED = 1;

		[ScriptName("MEDIA_ERR_DECODE")]
		public const ushort MEDIA_ERR_DECODE = 3;

		[ScriptName("MEDIA_ERR_NETWORK")]
		public const ushort MEDIA_ERR_NETWORK = 2;

		[ScriptName("MEDIA_ERR_SRC_NOT_SUPPORTED")]
		public const ushort MEDIA_ERR_SRC_NOT_SUPPORTED = 4;
	}
}
