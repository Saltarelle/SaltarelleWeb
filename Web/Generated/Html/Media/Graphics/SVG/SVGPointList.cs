using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPointList {
		internal SVGPointList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SVGPoint this[uint index] {
			get { return default(SVGPoint); }
		}

		public SVGPoint AppendItem(SVGPoint newItem) {
			return default(SVGPoint);
		}

		public void Clear() {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGPoint> GetEnumerator() {
			return default(IEnumerator<SVGPoint>);
		}

		public SVGPoint GetItem(uint index) {
			return default(SVGPoint);
		}

		public SVGPoint Initialize(SVGPoint newItem) {
			return default(SVGPoint);
		}

		public SVGPoint InsertItemBefore(SVGPoint newItem, uint index) {
			return default(SVGPoint);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}

		[IntrinsicProperty]
		public uint NumberOfItems {
			get { return 0; }
		}

		public SVGPoint RemoveItem(uint index) {
			return default(SVGPoint);
		}

		public SVGPoint ReplaceItem(SVGPoint newItem, uint index) {
			return default(SVGPoint);
		}
	}
}
