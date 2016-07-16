using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ImageData {
		internal ImageData() {
		}

		public ImageData(int sw, int sh) {
		}

		public ImageData(Uint8ClampedArray data, int sw) {
		}

		public ImageData(Uint8ClampedArray data, int sw, int sh) {
		}

		[IntrinsicProperty]
		public Uint8ClampedArray Data {
			get {
				return default(Uint8ClampedArray);
			}
		}

		[IntrinsicProperty]
		public int Height {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int Width {
			get {
				return 0;
			}
		}
	}
}
