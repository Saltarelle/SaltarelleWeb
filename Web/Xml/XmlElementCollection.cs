using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("HTMLCollection")]
	public partial class XmlElementCollection {
		internal XmlElementCollection() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public XmlElement this[string name] {
			get {
				return null;
			}
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public XmlElement this[uint index] {
			get {
				return null;
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<XmlElement> GetEnumerator() {
			return null;
		}

		public XmlElement Item(uint index) {
			return null;
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		public XmlElement NamedItem(string name) {
			return null;
		}
	}
}
