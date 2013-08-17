using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Node")]
	public partial class XmlNode : EventTarget {
		internal XmlNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture) {
		}

		public XmlNode AppendChild(XmlNode node) {
			return default(XmlNode);
		}

		[ScriptName("ATTRIBUTE_NODE")]
		public const ushort ATTRIBUTE_NODE = 2;

		[IntrinsicProperty]
		public string BaseURI {
			get {
				return null;
			}
		}

		[ScriptName("CDATA_SECTION_NODE")]
		public const ushort CDATA_SECTION_NODE = 4;

		[IntrinsicProperty]
		public XmlNodeList ChildNodes {
			get {
				return default(XmlNodeList);
			}
		}

		public XmlNode CloneNode() {
			return default(XmlNode);
		}

		public XmlNode CloneNode(bool deep) {
			return default(XmlNode);
		}

		[ScriptName("COMMENT_NODE")]
		public const ushort COMMENT_NODE = 8;

		public DocumentPosition CompareDocumentPosition(XmlNode other) {
			return default(DocumentPosition);
		}

		public bool Contains(XmlNode other) {
			return false;
		}

		[ScriptName("DOCUMENT_FRAGMENT_NODE")]
		public const ushort DOCUMENT_FRAGMENT_NODE = 11;

		[ScriptName("DOCUMENT_NODE")]
		public const ushort DOCUMENT_NODE = 9;

		[ScriptName("DOCUMENT_POSITION_CONTAINED_BY")]
		public const ushort DOCUMENT_POSITION_CONTAINED_BY = 16;

		[ScriptName("DOCUMENT_POSITION_CONTAINS")]
		public const ushort DOCUMENT_POSITION_CONTAINS = 8;

		[ScriptName("DOCUMENT_POSITION_DISCONNECTED")]
		public const ushort DOCUMENT_POSITION_DISCONNECTED = 1;

		[ScriptName("DOCUMENT_POSITION_FOLLOWING")]
		public const ushort DOCUMENT_POSITION_FOLLOWING = 4;

		[ScriptName("DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC")]
		public const ushort DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 32;

		[ScriptName("DOCUMENT_POSITION_PRECEDING")]
		public const ushort DOCUMENT_POSITION_PRECEDING = 2;

		[ScriptName("DOCUMENT_TYPE_NODE")]
		public const ushort DOCUMENT_TYPE_NODE = 10;

		[ScriptName("ELEMENT_NODE")]
		public const ushort ELEMENT_NODE = 1;

		[ScriptName("ENTITY_NODE")]
		public const ushort ENTITY_NODE = 6;

		[ScriptName("ENTITY_REFERENCE_NODE")]
		public const ushort ENTITY_REFERENCE_NODE = 5;

		[IntrinsicProperty]
		public XmlNode FirstChild {
			get {
				return default(XmlNode);
			}
		}

		public object GetUserData(string key) {
			return null;
		}

		public bool HasAttributes() {
			return false;
		}

		public bool HasChildNodes() {
			return false;
		}

		public XmlNode InsertBefore(XmlNode node, XmlNode child) {
			return default(XmlNode);
		}

		public bool IsDefaultNamespace(string @namespace) {
			return false;
		}

		public bool IsEqualNode(XmlNode node) {
			return false;
		}

		[IntrinsicProperty]
		public XmlNode LastChild {
			get {
				return default(XmlNode);
			}
		}

		[IntrinsicProperty]
		public string LocalName {
			get {
				return null;
			}
		}

		public string LookupNamespaceURI(string prefix) {
			return null;
		}

		public string LookupPrefix(string @namespace) {
			return null;
		}

		[IntrinsicProperty]
		public string NamespaceURI {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public XmlNode NextSibling {
			get {
				return default(XmlNode);
			}
		}

		[IntrinsicProperty]
		public string NodeName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public XmlNodeType NodeType {
			get {
				return default(XmlNodeType);
			}
		}

		[IntrinsicProperty]
		public string NodeValue {
			get {
				return null;
			}
			set {
			}
		}

		public void Normalize() {
		}

		[ScriptName("NOTATION_NODE")]
		public const ushort NOTATION_NODE = 12;

		[IntrinsicProperty]
		public DocumentBase OwnerDocument {
			get {
				return default(DocumentBase);
			}
		}

		[IntrinsicProperty]
		public XmlElement ParentElement {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public XmlNode ParentNode {
			get {
				return default(XmlNode);
			}
		}

		[IntrinsicProperty]
		public string Prefix {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public XmlNode PreviousSibling {
			get {
				return default(XmlNode);
			}
		}

		[ScriptName("PROCESSING_INSTRUCTION_NODE")]
		public const ushort PROCESSING_INSTRUCTION_NODE = 7;

		public XmlNode RemoveChild(XmlNode child) {
			return default(XmlNode);
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture) {
		}

		public XmlNode ReplaceChild(XmlNode node, XmlNode child) {
			return default(XmlNode);
		}

		[ScriptName("TEXT_NODE")]
		public const ushort TEXT_NODE = 3;

		[IntrinsicProperty]
		public string TextContent {
			get {
				return null;
			}
			set {
			}
		}
	}
}
