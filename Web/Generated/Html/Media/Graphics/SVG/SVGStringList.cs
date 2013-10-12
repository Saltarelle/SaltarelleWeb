using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGStringList {
		internal SVGStringList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public string this[uint index] {
			get {
				return null;
			}
		}

		public string AppendItem(string newItem) {
			return null;
		}

		public void Clear() {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<string> GetEnumerator() {
			return null;
		}

		public string GetItem(uint index) {
			return null;
		}

		public string Initialize(string newItem) {
			return null;
		}

		public string InsertItemBefore(string newItem, uint index) {
			return null;
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public uint NumberOfItems {
			get {
				return 0;
			}
		}

		public string RemoveItem(uint index) {
			return null;
		}

		public string ReplaceItem(string newItem, uint index) {
			return null;
		}
	}
}
