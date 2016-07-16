using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGTransformList {
		internal SVGTransformList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SVGTransform this[int index] {
			get {
				return default(SVGTransform);
			}
		}

		public SVGTransform AppendItem(SVGTransform newItem) {
			return default(SVGTransform);
		}

		public void Clear() {
		}

		public SVGTransform Consolidate() {
			return default(SVGTransform);
		}

		public SVGTransform CreateSVGTransformFromMatrix(SVGMatrix matrix) {
			return default(SVGTransform);
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGTransform> GetEnumerator() {
			return null;
		}

		public SVGTransform GetItem(int index) {
			return default(SVGTransform);
		}

		public SVGTransform Initialize(SVGTransform newItem) {
			return default(SVGTransform);
		}

		public SVGTransform InsertItemBefore(SVGTransform newItem, int index) {
			return default(SVGTransform);
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

		public SVGTransform RemoveItem(int index) {
			return default(SVGTransform);
		}

		public SVGTransform ReplaceItem(SVGTransform newItem, int index) {
			return default(SVGTransform);
		}
	}
}
