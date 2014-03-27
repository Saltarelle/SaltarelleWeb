using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPathSegList {
		internal SVGPathSegList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SVGPathSeg this[int index] {
			get {
				return default(SVGPathSeg);
			}
		}

		public SVGPathSeg AppendItem(SVGPathSeg newItem) {
			return default(SVGPathSeg);
		}

		public void Clear() {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGPathSeg> GetEnumerator() {
			return null;
		}

		public SVGPathSeg GetItem(int index) {
			return default(SVGPathSeg);
		}

		public SVGPathSeg Initialize(SVGPathSeg newItem) {
			return default(SVGPathSeg);
		}

		public SVGPathSeg InsertItemBefore(SVGPathSeg newItem, int index) {
			return default(SVGPathSeg);
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int NumberOfItems {
			get {
				return 0;
			}
		}

		public SVGPathSeg RemoveItem(int index) {
			return default(SVGPathSeg);
		}

		public SVGPathSeg ReplaceItem(SVGPathSeg newItem, int index) {
			return default(SVGPathSeg);
		}
	}
}
