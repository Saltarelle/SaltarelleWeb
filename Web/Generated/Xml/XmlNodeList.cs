using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("NodeList")]
	public partial class XmlNodeList {
		internal XmlNodeList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public XmlNode this[uint index] {
			get { return default(XmlNode); }
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<XmlNode> GetEnumerator() {
			return default(IEnumerator<XmlNode>);
		}

		public XmlNode Item(uint index) {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}
	}
}
