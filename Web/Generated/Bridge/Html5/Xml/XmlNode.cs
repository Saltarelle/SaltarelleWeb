namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Node")]
	public partial class XmlNode : EventTarget
	{
		internal XmlNode()
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture)
		{
		}

		public void AddEventListener(XmlNodeEvents type, Action listener)
		{
		}

		public void AddEventListener(XmlNodeEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(XmlNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(XmlNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener)
		{
		}

		public void AddEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture)
		{
		}

		public void AddEventListener(XmlNodeEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(XmlNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public XmlNode AppendChild(XmlNode node)
		{
			return default(XmlNode);
		}

		[Name("ATTRIBUTE_NODE")]
		public const ushort ATTRIBUTE_NODE = 2;

		[FieldProperty]
		public string BaseURI
		{
			get {
				return null;
			}
		}

		[Name("CDATA_SECTION_NODE")]
		public const ushort CDATA_SECTION_NODE = 4;

		[FieldProperty]
		public XmlNodeList ChildNodes
		{
			get {
				return default(XmlNodeList);
			}
		}

		public XmlNode CloneNode()
		{
			return default(XmlNode);
		}

		public XmlNode CloneNode(bool deep)
		{
			return default(XmlNode);
		}

		[Name("COMMENT_NODE")]
		public const ushort COMMENT_NODE = 8;

		public DocumentPosition CompareDocumentPosition(XmlNode other)
		{
			return default(DocumentPosition);
		}

		public bool Contains(XmlNode other)
		{
			return false;
		}

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

		[FieldProperty]
		public XmlNode FirstChild
		{
			get {
				return default(XmlNode);
			}
		}

		public object GetUserData(string key)
		{
			return null;
		}

		public bool HasAttributes()
		{
			return false;
		}

		public bool HasChildNodes()
		{
			return false;
		}

		public XmlNode InsertBefore(XmlNode node, XmlNode child)
		{
			return default(XmlNode);
		}

		public bool IsDefaultNamespace(string @namespace)
		{
			return false;
		}

		public bool IsEqualNode(XmlNode node)
		{
			return false;
		}

		[FieldProperty]
		public XmlNode LastChild
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public string LocalName
		{
			get {
				return null;
			}
		}

		public string LookupNamespaceURI(string prefix)
		{
			return null;
		}

		public string LookupPrefix(string @namespace)
		{
			return null;
		}

		[FieldProperty]
		public string NamespaceURI
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public XmlNode NextSibling
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public string NodeName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public XmlNodeType NodeType
		{
			get {
				return default(XmlNodeType);
			}
		}

		[FieldProperty]
		public string NodeValue
		{
			get {
				return null;
			}
			set {
			}
		}

		public void Normalize()
		{
		}

		[Name("NOTATION_NODE")]
		public const ushort NOTATION_NODE = 12;

		[FieldProperty]
		public DocumentBase OwnerDocument
		{
			get {
				return default(DocumentBase);
			}
		}

		[FieldProperty]
		public XmlElement ParentElement
		{
			get {
				return default(XmlElement);
			}
		}

		[FieldProperty]
		public XmlNode ParentNode
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public string Prefix
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public XmlNode PreviousSibling
		{
			get {
				return default(XmlNode);
			}
		}

		[Name("PROCESSING_INSTRUCTION_NODE")]
		public const ushort PROCESSING_INSTRUCTION_NODE = 7;

		public XmlNode RemoveChild(XmlNode child)
		{
			return default(XmlNode);
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture)
		{
		}

		public void RemoveEventListener(XmlNodeEvents type, Action listener)
		{
		}

		public void RemoveEventListener(XmlNodeEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(XmlNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(XmlNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener)
		{
		}

		public void RemoveEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture)
		{
		}

		public void RemoveEventListener(XmlNodeEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(XmlNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public XmlNode ReplaceChild(XmlNode node, XmlNode child)
		{
			return default(XmlNode);
		}

		[Name("TEXT_NODE")]
		public const ushort TEXT_NODE = 3;

		[FieldProperty]
		public string TextContent
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
