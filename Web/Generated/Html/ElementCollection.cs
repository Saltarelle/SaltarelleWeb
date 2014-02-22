using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("HTMLCollection")]
	public partial class ElementCollection {
		internal ElementCollection() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public Element this[string name] {
			get {
				return default(Element);
			}
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public Element this[uint index] {
			get {
				return default(Element);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<Element> GetEnumerator() {
			return null;
		}

		public Element Item(uint index) {
			return default(Element);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		public Element NamedItem(string name) {
			return default(Element);
		}
	}
}
