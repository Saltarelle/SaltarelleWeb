using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("HTMLCollection")]
	public partial class ElementCollection {
		internal ElementCollection() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public object this[string name] {
			get {
				return null;
			}
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public XmlElement this[uint index] {
			get {
				return default(XmlElement);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<XmlElement> GetEnumerator() {
			return null;
		}

		public XmlElement Item(uint index) {
			return default(XmlElement);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		public object NamedItem(string name) {
			return null;
		}
	}
}
