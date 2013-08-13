using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AudioBuffer {
		internal AudioBuffer() {
		}

		[IntrinsicProperty]
		public double Duration {
			get {
				return 0;
			}
		}

		public Float32Array GetChannelData(uint channel) {
			return default(Float32Array);
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int NumberOfChannels {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public float SampleRate {
			get {
				return 0;
			}
		}
	}
}
