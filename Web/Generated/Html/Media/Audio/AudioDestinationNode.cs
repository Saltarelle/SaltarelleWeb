using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AudioDestinationNode : AudioNode {
		internal AudioDestinationNode() {
		}

		[IntrinsicProperty]
		public uint MaxChannelCount {
			get { return 0; }
		}
	}
}
