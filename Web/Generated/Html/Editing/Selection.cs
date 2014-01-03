using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Editing {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Selection {
		internal Selection() {
		}

		public void AddRange(Range range) {
		}

		[IntrinsicProperty]
		public XmlNode AnchorNode {
			get {
				return default(XmlNode);
			}
		}

		[IntrinsicProperty]
		public uint AnchorOffset {
			get {
				return 0;
			}
		}

		public void Collapse(XmlNode node, uint offset) {
		}

		public void CollapseToEnd() {
		}

		public void CollapseToStart() {
		}

		public bool ContainsNode(XmlNode node, bool partlyContained) {
			return false;
		}

		public void DeleteFromDocument() {
		}

		public void Extend(XmlNode node, uint offset) {
		}

		[IntrinsicProperty]
		public XmlNode FocusNode {
			get {
				return default(XmlNode);
			}
		}

		[IntrinsicProperty]
		public uint FocusOffset {
			get {
				return 0;
			}
		}

		public Range GetRangeAt(uint index) {
			return default(Range);
		}

		[IntrinsicProperty]
		public bool IsCollapsed {
			get {
				return false;
			}
		}

		public void Modify(string alter, string direction, string granularity) {
		}

		[IntrinsicProperty]
		public uint RangeCount {
			get {
				return 0;
			}
		}

		public void RemoveAllRanges() {
		}

		public void RemoveRange(Range range) {
		}

		public void SelectAllChildren(XmlNode node) {
		}
	}
}
