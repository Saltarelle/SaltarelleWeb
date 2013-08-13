using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaStreamAudioDestinationNode : AudioNode {
		internal MediaStreamAudioDestinationNode() {
		}

		[IntrinsicProperty]
		public MediaStream Stream {
			get {
				return default(MediaStream);
			}
		}
	}
}
