namespace Bridge.Html5.Xml
{
	[Namespace("false"), External, Name("Node")]
	public partial class XmlNode : EventTarget
	{
		internal extern XmlNode();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture);

		public extern void AddEventListener(XmlNodeEvents type, Action listener);

		public extern void AddEventListener(XmlNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener);

		public extern void AddEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture);

		public extern void AddEventListener(XmlNodeEvents type, IEventListener listener);

		public extern void AddEventListener(XmlNodeEvents type, IEventListener listener, bool capture);

		public extern XmlNode AppendChild(XmlNode node);

		[Name("ATTRIBUTE_NODE")]
		public const ushort ATTRIBUTE_NODE = 2;

		public readonly string BaseURI;

		[Name("CDATA_SECTION_NODE")]
		public const ushort CDATA_SECTION_NODE = 4;

		public readonly XmlNodeList ChildNodes;

		public extern XmlNode CloneNode();

		public extern XmlNode CloneNode(bool deep);

		[Name("COMMENT_NODE")]
		public const ushort COMMENT_NODE = 8;

		public extern DocumentPosition CompareDocumentPosition(XmlNode other);

		public extern bool Contains(XmlNode other);

		[Name("DOCUMENT_FRAGMENT_NODE")]
		public const ushort DOCUMENT_FRAGMENT_NODE = 11;

		[Name("DOCUMENT_NODE")]
		public const ushort DOCUMENT_NODE = 9;

		[Name("DOCUMENT_POSITION_CONTAINED_BY")]
		public const ushort DOCUMENT_POSITION_CONTAINED_BY = 16;

		[Name("DOCUMENT_POSITION_CONTAINS")]
		public const ushort DOCUMENT_POSITION_CONTAINS = 8;

		[Name("DOCUMENT_POSITION_DISCONNECTED")]
		public const ushort DOCUMENT_POSITION_DISCONNECTED = 1;

		[Name("DOCUMENT_POSITION_FOLLOWING")]
		public const ushort DOCUMENT_POSITION_FOLLOWING = 4;

		[Name("DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC")]
		public const ushort DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 32;

		[Name("DOCUMENT_POSITION_PRECEDING")]
		public const ushort DOCUMENT_POSITION_PRECEDING = 2;

		[Name("DOCUMENT_TYPE_NODE")]
		public const ushort DOCUMENT_TYPE_NODE = 10;

		[Name("ELEMENT_NODE")]
		public const ushort ELEMENT_NODE = 1;

		[Name("ENTITY_NODE")]
		public const ushort ENTITY_NODE = 6;

		[Name("ENTITY_REFERENCE_NODE")]
		public const ushort ENTITY_REFERENCE_NODE = 5;

		public readonly XmlNode FirstChild;

		public extern object GetUserData(string key);

		public extern bool HasAttributes();

		public extern bool HasChildNodes();

		public extern XmlNode InsertBefore(XmlNode node, XmlNode child);

		public extern bool IsDefaultNamespace(string @namespace);

		public extern bool IsEqualNode(XmlNode node);

		public readonly XmlNode LastChild;

		public readonly string LocalName;

		public extern string LookupNamespaceURI(string prefix);

		public extern string LookupPrefix(string @namespace);

		public readonly string NamespaceURI;

		public readonly XmlNode NextSibling;

		public readonly string NodeName;

		public readonly XmlNodeType NodeType;

		public string NodeValue;

		public extern void Normalize();

		[Name("NOTATION_NODE")]
		public const ushort NOTATION_NODE = 12;

		public readonly DocumentBase OwnerDocument;

		public readonly XmlElement ParentElement;

		public readonly XmlNode ParentNode;

		public readonly string Prefix;

		public readonly XmlNode PreviousSibling;

		[Name("PROCESSING_INSTRUCTION_NODE")]
		public const ushort PROCESSING_INSTRUCTION_NODE = 7;

		public extern XmlNode RemoveChild(XmlNode child);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture);

		public extern void RemoveEventListener(XmlNodeEvents type, Action listener);

		public extern void RemoveEventListener(XmlNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener);

		public extern void RemoveEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture);

		public extern void RemoveEventListener(XmlNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlNodeEvents type, IEventListener listener, bool capture);

		public extern XmlNode ReplaceChild(XmlNode node, XmlNode child);

		[Name("TEXT_NODE")]
		public const ushort TEXT_NODE = 3;

		public string TextContent;
	}
}
