using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class GainNode : AudioNode {
		internal GainNode() {
		}

		[IntrinsicProperty]
		public AudioParam Gain {
			get {
				return default(AudioParam);
			}
		}
	}
}
