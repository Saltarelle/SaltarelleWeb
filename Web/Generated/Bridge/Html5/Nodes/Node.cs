using Bridge.Html5.Elements;

namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class Node : EventTarget
	{
		internal extern Node();

		public extern void AddEventListener(NodeEvents type, Action listener);

		public extern void AddEventListener(NodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(NodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(NodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(NodeEvents type, HtmlEventHandlerWithTarget<Node> listener);

		public extern void AddEventListener(NodeEvents type, HtmlEventHandlerWithTarget<Node> listener, bool capture);

		public extern void AddEventListener(NodeEvents type, IEventListener listener);

		public extern void AddEventListener(NodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Node> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Node> listener, bool capture);

		public extern Node AppendChild(Node node);

		[Name("ATTRIBUTE_NODE")]
		public const ushort ATTRIBUTE_NODE = 2;

		public readonly string BaseURI;

		[Name("CDATA_SECTION_NODE")]
		public const ushort CDATA_SECTION_NODE = 4;

		public readonly NodeList ChildNodes;

		public extern Node CloneNode();

		public extern Node CloneNode(bool deep);

		[Name("COMMENT_NODE")]
		public const ushort COMMENT_NODE = 8;

		public extern DocumentPosition CompareDocumentPosition(Node other);

		public extern bool Contains(Node other);

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

		public readonly Node FirstChild;

		public extern object GetUserData(string key);

		public extern bool HasAttributes();

		public extern bool HasChildNodes();

		public extern Node InsertBefore(Node node, Node child);

		public extern bool IsDefaultNamespace(string @namespace);

		public extern bool IsEqualNode(Node node);

		public readonly Node LastChild;

		public readonly string LocalName;

		public extern string LookupNamespaceURI(string prefix);

		public extern string LookupPrefix(string @namespace);

		public readonly string NamespaceURI;

		public readonly Node NextSibling;

		public readonly string NodeName;

		public readonly NodeType NodeType;

		public string NodeValue;

		public extern void Normalize();

		[Name("NOTATION_NODE")]
		public const ushort NOTATION_NODE = 12;

		public readonly DocumentBase OwnerDocument;

		public readonly Node ParentElement;

		public readonly Node ParentNode;

		public readonly string Prefix;

		public readonly Node PreviousSibling;

		[Name("PROCESSING_INSTRUCTION_NODE")]
		public const ushort PROCESSING_INSTRUCTION_NODE = 7;

		public extern Node RemoveChild(Node child);

		public extern void RemoveEventListener(NodeEvents type, Action listener);

		public extern void RemoveEventListener(NodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(NodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(NodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(NodeEvents type, HtmlEventHandlerWithTarget<Node> listener);

		public extern void RemoveEventListener(NodeEvents type, HtmlEventHandlerWithTarget<Node> listener, bool capture);

		public extern void RemoveEventListener(NodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(NodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Node> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Node> listener, bool capture);

		public extern Node ReplaceChild(Node node, Node child);

		[Name("TEXT_NODE")]
		public const ushort TEXT_NODE = 3;

		public string TextContent;
	}
}
