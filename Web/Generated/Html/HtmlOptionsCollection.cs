using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("HTMLOptionsCollection")]
	public partial class HtmlOptionsCollection : ElementCollection {
		internal HtmlOptionsCollection() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public object this[string name] {
			get {
				return null;
			}
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public OptionElement this[uint index] {
			set {
			}
		}

		public void Add(TypeOption<OptionElement, OptGroupElement> element) {
		}

		public void Add(TypeOption<OptionElement, OptGroupElement> element, TypeOption<Element, int> before) {
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
			set {
			}
		}

		public object NamedItem(string name) {
			return null;
		}

		public void Remove(int index) {
		}

		[IntrinsicProperty]
		public int SelectedIndex {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
