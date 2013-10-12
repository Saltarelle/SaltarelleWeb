using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class VTTRegionList {
		internal VTTRegionList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public VTTRegion this[uint index] {
			get {
				return default(VTTRegion);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<VTTRegion> GetEnumerator() {
			return null;
		}

		public VTTRegion GetRegionById(string id) {
			return default(VTTRegion);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}
	}
}
