using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGLengthList {
		internal SVGLengthList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SVGLength this[uint index] {
			get { return default(SVGLength); }
		}

		public SVGLength AppendItem(SVGLength newItem) {
			return default(SVGLength);
		}

		public void Clear() {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGLength> GetEnumerator() {
			return default(IEnumerator<SVGLength>);
		}

		public SVGLength GetItem(uint index) {
			return default(SVGLength);
		}

		public SVGLength Initialize(SVGLength newItem) {
			return default(SVGLength);
		}

		public SVGLength InsertItemBefore(SVGLength newItem, uint index) {
			return default(SVGLength);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}

		[IntrinsicProperty]
		public uint NumberOfItems {
			get { return 0; }
		}

		public SVGLength RemoveItem(uint index) {
			return default(SVGLength);
		}

		public SVGLength ReplaceItem(SVGLength newItem, uint index) {
			return default(SVGLength);
		}
	}
}
