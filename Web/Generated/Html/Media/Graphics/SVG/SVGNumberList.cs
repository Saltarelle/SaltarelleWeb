using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGNumberList {
		internal SVGNumberList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SVGNumber this[int index] {
			get {
				return default(SVGNumber);
			}
		}

		public SVGNumber AppendItem(SVGNumber newItem) {
			return default(SVGNumber);
		}

		public void Clear() {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGNumber> GetEnumerator() {
			return null;
		}

		public SVGNumber GetItem(int index) {
			return default(SVGNumber);
		}

		public SVGNumber Initialize(SVGNumber newItem) {
			return default(SVGNumber);
		}

		public SVGNumber InsertItemBefore(SVGNumber newItem, int index) {
			return default(SVGNumber);
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

		public SVGNumber RemoveItem(int index) {
			return default(SVGNumber);
		}

		public SVGNumber ReplaceItem(SVGNumber newItem, int index) {
			return default(SVGNumber);
		}
	}
}
