using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ImageData {
		internal ImageData() {
		}

		[IntrinsicProperty]
		public Uint8ClampedArray Data {
			get {
				return default(Uint8ClampedArray);
			}
		}

		[IntrinsicProperty]
		public uint Height {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public uint Width {
			get {
				return 0;
			}
		}
	}
}
