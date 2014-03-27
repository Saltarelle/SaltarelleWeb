using System.Runtime.CompilerServices;

namespace System.Xml.XPath {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class XPathResult {
		internal XPathResult() {
		}

		[ScriptName("ANY_TYPE")]
		public const ushort ANY_TYPE = 0;

		[ScriptName("ANY_UNORDERED_NODE_TYPE")]
		public const ushort ANY_UNORDERED_NODE_TYPE = 8;

		[ScriptName("BOOLEAN_TYPE")]
		public const ushort BOOLEAN_TYPE = 3;

		[IntrinsicProperty]
		public bool BooleanValue {
			get {
				return false;
			}
		}

		[ScriptName("FIRST_ORDERED_NODE_TYPE")]
		public const ushort FIRST_ORDERED_NODE_TYPE = 9;

		[IntrinsicProperty]
		public bool InvalidIteratorState {
			get {
				return false;
			}
		}

		public XmlNode IterateNext() {
			return default(XmlNode);
		}

		[ScriptName("NUMBER_TYPE")]
		public const ushort NUMBER_TYPE = 1;

		[IntrinsicProperty]
		public double NumberValue {
			get {
				return 0;
			}
		}

		[ScriptName("ORDERED_NODE_ITERATOR_TYPE")]
		public const ushort ORDERED_NODE_ITERATOR_TYPE = 5;

		[ScriptName("ORDERED_NODE_SNAPSHOT_TYPE")]
		public const ushort ORDERED_NODE_SNAPSHOT_TYPE = 7;

		[IntrinsicProperty]
		public ResultType ResultType {
			get {
				return default(ResultType);
			}
		}

		[IntrinsicProperty]
		public XmlNode SingleNodeValue {
			get {
				return default(XmlNode);
			}
		}

		public XmlNode SnapshotItem(int index) {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public int SnapshotLength {
			get {
				return 0;
			}
		}

		[ScriptName("STRING_TYPE")]
		public const ushort STRING_TYPE = 2;

		[IntrinsicProperty]
		public string StringValue {
			get {
				return null;
			}
		}

		[ScriptName("UNORDERED_NODE_ITERATOR_TYPE")]
		public const ushort UNORDERED_NODE_ITERATOR_TYPE = 4;

		[ScriptName("UNORDERED_NODE_SNAPSHOT_TYPE")]
		public const ushort UNORDERED_NODE_SNAPSHOT_TYPE = 6;
	}
}
