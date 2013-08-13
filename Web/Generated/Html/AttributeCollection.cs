using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class AttributeCollection {
		internal AttributeCollection() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public XmlAttribute this[string name] {
			get {
				return default(XmlAttribute);
			}
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public XmlAttribute this[uint index] {
			get {
				return default(XmlAttribute);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<XmlAttribute> GetEnumerator() {
			return null;
		}

		public XmlAttribute GetNamedItem(string name) {
			return default(XmlAttribute);
		}

		public XmlAttribute GetNamedItemNS(string namespaceURI, string localName) {
			return default(XmlAttribute);
		}

		public XmlAttribute Item(uint index) {
			return default(XmlAttribute);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		public XmlAttribute RemoveNamedItem(string name) {
			return default(XmlAttribute);
		}

		public XmlAttribute RemoveNamedItemNS(string namespaceURI, string localName) {
			return default(XmlAttribute);
		}

		public XmlAttribute SetNamedItem(XmlAttribute arg) {
			return default(XmlAttribute);
		}

		public XmlAttribute SetNamedItemNS(XmlAttribute arg) {
			return default(XmlAttribute);
		}
	}
}
