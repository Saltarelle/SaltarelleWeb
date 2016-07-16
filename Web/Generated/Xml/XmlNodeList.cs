using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("NodeList")]
	public partial class XmlNodeList {
		internal XmlNodeList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public XmlNode this[int index] {
			get {
				return default(XmlNode);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<XmlNode> GetEnumerator() {
			return null;
		}

		public XmlNode Item(int index) {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}
	}
}
