using Bridge.Html5.Editing;
using Bridge.Html5.WebComponents;
using Bridge.Html5.Xml;
using Bridge.Html5.Xml.XPath;
using System;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("document")]
	public static partial class Document
	{
		public static void AddEventListener(DocumentBaseEvents type, Action listener)
		{
		}

		public static void AddEventListener(DocumentBaseEvents type, Action listener, bool capture)
		{
		}

		public static void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener)
		{
		}

		public static void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public static void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener)
		{
		}

		public static void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture)
		{
		}

		public static void AddEventListener(DocumentBaseEvents type, IEventListener listener)
		{
		}

		public static void AddEventListener(DocumentBaseEvents type, IEventListener listener, bool capture)
		{
		}

		public static void AddEventListener(DocumentInstanceEvents type, Action listener)
		{
		}

		public static void AddEventListener(DocumentInstanceEvents type, Action listener, bool capture)
		{
		}

		public static void AddEventListener(DocumentInstanceEvents type, HtmlEventHandler listener)
		{
		}

		public static void AddEventListener(DocumentInstanceEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public static void AddEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener)
		{
		}

		public static void AddEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture)
		{
		}

		public static void AddEventListener(DocumentInstanceEvents type, IEventListener listener)
		{
		}

		public static void AddEventListener(DocumentInstanceEvents type, IEventListener listener, bool capture)
		{
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener)
		{
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener)
		{
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener)
		{
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture)
		{
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture)
		{
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture)
		{
		}

		public static void AddEventListener(string type, IEventListener listener)
		{
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture)
		{
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted)
		{
		}

		public static void AddEventListener(XmlNodeEvents type, Action listener)
		{
		}

		public static void AddEventListener(XmlNodeEvents type, Action listener, bool capture)
		{
		}

		public static void AddEventListener(XmlNodeEvents type, HtmlEventHandler listener)
		{
		}

		public static void AddEventListener(XmlNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public static void AddEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener)
		{
		}

		public static void AddEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture)
		{
		}

		public static void AddEventListener(XmlNodeEvents type, IEventListener listener)
		{
		}

		public static void AddEventListener(XmlNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public static XmlNode AdoptNode(XmlNode node)
		{
			return default(XmlNode);
		}

		[FieldProperty]
		public static string AlinkColor
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public static object All
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static ElementCollection Anchors
		{
			get {
				return default(ElementCollection);
			}
		}

		public static XmlNode AppendChild(XmlNode node)
		{
			return default(XmlNode);
		}

		[FieldProperty]
		public static ElementCollection Applets
		{
			get {
				return default(ElementCollection);
			}
		}

		[Name("ATTRIBUTE_NODE")]
		public const ushort ATTRIBUTE_NODE = 2;

		[FieldProperty]
		public static string BaseURI
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string BgColor
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public static Element Body
		{
			get {
				return default(Element);
			}
			set {
			}
		}

		public static void CaptureEvents()
		{
		}

		public static CaretPosition CaretPositionFromPoint(double x, double y)
		{
			return default(CaretPosition);
		}

		[Name("CDATA_SECTION_NODE")]
		public const ushort CDATA_SECTION_NODE = 4;

		[FieldProperty]
		public static string CharacterSet
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static int ChildElementCount
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public static XmlNodeList ChildNodes
		{
			get {
				return default(XmlNodeList);
			}
		}

		public static void Clear()
		{
		}

		public static XmlNode CloneNode()
		{
			return default(XmlNode);
		}

		public static XmlNode CloneNode(bool deep)
		{
			return default(XmlNode);
		}

		public static void Close()
		{
		}

		[Name("COMMENT_NODE")]
		public const ushort COMMENT_NODE = 8;

		public static DocumentPosition CompareDocumentPosition(XmlNode other)
		{
			return default(DocumentPosition);
		}

		[FieldProperty]
		public static string CompatMode
		{
			get {
				return null;
			}
		}

		public static bool Contains(XmlNode other)
		{
			return false;
		}

		[FieldProperty]
		public static string ContentType
		{
			get {
				return null;
			}
		}

		public static DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from)
		{
			return default(DOMPoint);
		}

		public static DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options)
		{
			return default(DOMPoint);
		}

		public static DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from)
		{
			return default(DOMQuad);
		}

		public static DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options)
		{
			return default(DOMQuad);
		}

		public static DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from)
		{
			return default(DOMQuad);
		}

		public static DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options)
		{
			return default(DOMQuad);
		}

		[FieldProperty]
		public static string Cookie
		{
			get {
				return null;
			}
			set {
			}
		}

		public static XmlAttribute CreateAttribute(string name)
		{
			return default(XmlAttribute);
		}

		public static XmlAttribute CreateAttributeNS(string @namespace, string name)
		{
			return default(XmlAttribute);
		}

		public static XmlCDataSection CreateCDATASection(string data)
		{
			return default(XmlCDataSection);
		}

		public static XmlComment CreateComment(string data)
		{
			return default(XmlComment);
		}

		public static XmlDocumentFragment CreateDocumentFragment()
		{
			return default(XmlDocumentFragment);
		}

		public static Event CreateEvent(string @interface)
		{
			return default(Event);
		}

		public static XPathExpression CreateExpression(string expression, XPathNSResolver resolver)
		{
			return default(XPathExpression);
		}

		public static NodeIterator CreateNodeIterator(XmlNode root)
		{
			return default(NodeIterator);
		}

		public static NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow)
		{
			return default(NodeIterator);
		}

		public static NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow, INodeFilter filter)
		{
			return default(NodeIterator);
		}

		public static XPathNSResolver CreateNSResolver(XmlNode nodeResolver)
		{
			return default(XPathNSResolver);
		}

		public static XmlProcessingInstruction CreateProcessingInstruction(string target, string data)
		{
			return default(XmlProcessingInstruction);
		}

		public static Range CreateRange()
		{
			return default(Range);
		}

		public static XmlText CreateTextNode(string data)
		{
			return default(XmlText);
		}

		public static Touch CreateTouch()
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, double rotationAngle)
		{
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, double rotationAngle, double force)
		{
			return default(Touch);
		}

		public static TouchList CreateTouchList()
		{
			return default(TouchList);
		}

		[ExpandParams]
		public static TouchList CreateTouchList(Touch touch, params Touch[] touches)
		{
			return default(TouchList);
		}

		public static TouchList CreateTouchList(Touch[] touches)
		{
			return default(TouchList);
		}

		public static TreeWalker CreateTreeWalker(XmlNode root)
		{
			return default(TreeWalker);
		}

		public static TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow)
		{
			return default(TreeWalker);
		}

		public static TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow, INodeFilter filter)
		{
			return default(TreeWalker);
		}

		[FieldProperty]
		public static WindowInstance DefaultView
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public static string DesignMode
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public static string Dir
		{
			get {
				return null;
			}
			set {
			}
		}

		public static bool DispatchEvent(Event @event)
		{
			return false;
		}

		[FieldProperty]
		public static DocumentType Doctype
		{
			get {
				return default(DocumentType);
			}
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

		[FieldProperty]
		public static string DocumentURI
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string Domain
		{
			get {
				return null;
			}
			set {
			}
		}

		[Name("ELEMENT_NODE")]
		public const ushort ELEMENT_NODE = 1;

		[FieldProperty]
		public static ElementCollection Embeds
		{
			get {
				return default(ElementCollection);
			}
		}

		public static void EnableStyleSheetsForSet(string name)
		{
		}

		[Name("ENTITY_NODE")]
		public const ushort ENTITY_NODE = 6;

		[Name("ENTITY_REFERENCE_NODE")]
		public const ushort ENTITY_REFERENCE_NODE = 5;

		public static XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result)
		{
			return default(XPathResult);
		}

		public static bool ExecCommand(string commandId)
		{
			return false;
		}

		public static bool ExecCommand(string commandId, bool showUI)
		{
			return false;
		}

		public static bool ExecCommand(string commandId, bool showUI, string value)
		{
			return false;
		}

		[FieldProperty]
		public static string FgColor
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public static XmlNode FirstChild
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public static ElementCollection Forms
		{
			get {
				return default(ElementCollection);
			}
		}

		public static DOMQuad[] GetBoxQuads()
		{
			return null;
		}

		public static DOMQuad[] GetBoxQuads(BoxQuadOptions options)
		{
			return null;
		}

		public static ElementNodeList GetElementsByName(string elementName)
		{
			return default(ElementNodeList);
		}

		public static ElementNodeList GetItems()
		{
			return default(ElementNodeList);
		}

		public static ElementNodeList GetItems(string typeNames)
		{
			return default(ElementNodeList);
		}

		public static Selection GetSelection()
		{
			return default(Selection);
		}

		public static object GetUserData(string key)
		{
			return null;
		}

		public static bool HasAttributes()
		{
			return false;
		}

		public static bool HasChildNodes()
		{
			return false;
		}

		public static bool HasFocus()
		{
			return false;
		}

		[FieldProperty]
		public static HeadElement Head
		{
			get {
				return default(HeadElement);
			}
		}

		[FieldProperty]
		public static bool Hidden
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public static ElementCollection Images
		{
			get {
				return default(ElementCollection);
			}
		}

		[FieldProperty]
		public static DOMImplementation Implementation
		{
			get {
				return default(DOMImplementation);
			}
		}

		public static XmlNode ImportNode(XmlNode node)
		{
			return default(XmlNode);
		}

		public static XmlNode ImportNode(XmlNode node, bool deep)
		{
			return default(XmlNode);
		}

		[FieldProperty]
		public static string InputEncoding
		{
			get {
				return null;
			}
		}

		public static XmlNode InsertBefore(XmlNode node, XmlNode child)
		{
			return default(XmlNode);
		}

		public static bool IsDefaultNamespace(string @namespace)
		{
			return false;
		}

		public static bool IsEqualNode(XmlNode node)
		{
			return false;
		}

		[FieldProperty]
		public static XmlNode LastChild
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public static string LastModified
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string LastStyleSheetSet
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string LinkColor
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public static ElementCollection Links
		{
			get {
				return default(ElementCollection);
			}
		}

		[FieldProperty]
		public static string LocalName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static Location Location
		{
			get {
				return default(Location);
			}
		}

		public static string LookupNamespaceURI(string prefix)
		{
			return null;
		}

		public static string LookupPrefix(string @namespace)
		{
			return null;
		}

		[FieldProperty]
		public static string NamespaceURI
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static XmlNode NextSibling
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public static string NodeName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static XmlNodeType NodeType
		{
			get {
				return default(XmlNodeType);
			}
		}

		[FieldProperty]
		public static string NodeValue
		{
			get {
				return null;
			}
			set {
			}
		}

		public static void Normalize()
		{
		}

		[Name("NOTATION_NODE")]
		public const ushort NOTATION_NODE = 12;

		[FieldProperty, Name("onabort")]
		public static HtmlEventHandler OnAbort
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onafterscriptexecute")]
		public static HtmlEventHandler OnAfterscriptexecute
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onbeforescriptexecute")]
		public static HtmlEventHandler OnBeforescriptexecute
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onblur")]
		public static HtmlEventHandler OnBlur
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncanplay")]
		public static HtmlEventHandler OnCanplay
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncanplaythrough")]
		public static HtmlEventHandler OnCanplaythrough
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onchange")]
		public static HtmlEventHandler OnChange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onclick")]
		public static HtmlEventHandler OnClick
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncontextmenu")]
		public static HtmlEventHandler OnContextmenu
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncopy")]
		public static HtmlEventHandler OnCopy
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncut")]
		public static HtmlEventHandler OnCut
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondblclick")]
		public static HtmlEventHandler OnDblclick
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondrag")]
		public static HtmlEventHandler OnDrag
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragend")]
		public static HtmlEventHandler OnDragend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragenter")]
		public static HtmlEventHandler OnDragenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragleave")]
		public static HtmlEventHandler OnDragleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragover")]
		public static HtmlEventHandler OnDragover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragstart")]
		public static HtmlEventHandler OnDragstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondrop")]
		public static HtmlEventHandler OnDrop
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondurationchange")]
		public static HtmlEventHandler OnDurationchange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onemptied")]
		public static HtmlEventHandler OnEmptied
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onended")]
		public static HtmlEventHandler OnEnded
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onerror")]
		public static HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onfocus")]
		public static HtmlEventHandler OnFocus
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oninput")]
		public static HtmlEventHandler OnInput
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oninvalid")]
		public static HtmlEventHandler OnInvalid
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeydown")]
		public static HtmlEventHandler OnKeydown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeypress")]
		public static HtmlEventHandler OnKeypress
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeyup")]
		public static HtmlEventHandler OnKeyup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onload")]
		public static HtmlEventHandler OnLoad
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadeddata")]
		public static HtmlEventHandler OnLoadeddata
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadedmetadata")]
		public static HtmlEventHandler OnLoadedmetadata
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadstart")]
		public static HtmlEventHandler OnLoadstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmousedown")]
		public static HtmlEventHandler OnMousedown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseenter")]
		public static HtmlEventHandler OnMouseenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseleave")]
		public static HtmlEventHandler OnMouseleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmousemove")]
		public static HtmlEventHandler OnMousemove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseout")]
		public static HtmlEventHandler OnMouseout
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseover")]
		public static HtmlEventHandler OnMouseover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseup")]
		public static HtmlEventHandler OnMouseup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpaste")]
		public static HtmlEventHandler OnPaste
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpause")]
		public static HtmlEventHandler OnPause
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onplay")]
		public static HtmlEventHandler OnPlay
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onplaying")]
		public static HtmlEventHandler OnPlaying
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointercancel")]
		public static HtmlEventHandler OnPointercancel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerdown")]
		public static HtmlEventHandler OnPointerdown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerenter")]
		public static HtmlEventHandler OnPointerenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerleave")]
		public static HtmlEventHandler OnPointerleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointermove")]
		public static HtmlEventHandler OnPointermove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerout")]
		public static HtmlEventHandler OnPointerout
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerover")]
		public static HtmlEventHandler OnPointerover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerup")]
		public static HtmlEventHandler OnPointerup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onprogress")]
		public static HtmlEventHandler OnProgress
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onratechange")]
		public static HtmlEventHandler OnRatechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onreadystatechange")]
		public static HtmlEventHandler OnReadystatechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onreset")]
		public static HtmlEventHandler OnReset
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onscroll")]
		public static HtmlEventHandler OnScroll
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onseeked")]
		public static HtmlEventHandler OnSeeked
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onseeking")]
		public static HtmlEventHandler OnSeeking
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onselect")]
		public static HtmlEventHandler OnSelect
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onshow")]
		public static HtmlEventHandler OnShow
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onstalled")]
		public static HtmlEventHandler OnStalled
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsubmit")]
		public static HtmlEventHandler OnSubmit
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsuspend")]
		public static HtmlEventHandler OnSuspend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontimeupdate")]
		public static HtmlEventHandler OnTimeupdate
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchcancel")]
		public static HtmlEventHandler OnTouchcancel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchend")]
		public static HtmlEventHandler OnTouchend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchenter")]
		public static HtmlEventHandler OnTouchenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchleave")]
		public static HtmlEventHandler OnTouchleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchmove")]
		public static HtmlEventHandler OnTouchmove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchstart")]
		public static HtmlEventHandler OnTouchstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onvolumechange")]
		public static HtmlEventHandler OnVolumechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onwaiting")]
		public static HtmlEventHandler OnWaiting
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onwheel")]
		public static HtmlEventHandler OnWheel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public static DocumentBase Open()
		{
			return default(DocumentBase);
		}

		public static DocumentBase Open(string type)
		{
			return default(DocumentBase);
		}

		public static DocumentBase Open(string type, string replace)
		{
			return default(DocumentBase);
		}

		public static WindowInstance Open(string url, string name, string features)
		{
			return default(WindowInstance);
		}

		public static WindowInstance Open(string url, string name, string features, bool replace)
		{
			return default(WindowInstance);
		}

		[FieldProperty]
		public static DocumentBase OwnerDocument
		{
			get {
				return default(DocumentBase);
			}
		}

		[FieldProperty]
		public static XmlNode ParentNode
		{
			get {
				return default(XmlNode);
			}
		}

		[FieldProperty]
		public static ElementCollection Plugins
		{
			get {
				return default(ElementCollection);
			}
		}

		[FieldProperty]
		public static string PreferredStyleSheetSet
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string Prefix
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static XmlNode PreviousSibling
		{
			get {
				return default(XmlNode);
			}
		}

		[Name("PROCESSING_INSTRUCTION_NODE")]
		public const ushort PROCESSING_INSTRUCTION_NODE = 7;

		public static bool QueryCommandEnabled(string commandId)
		{
			return false;
		}

		public static bool QueryCommandIndeterm(string commandId)
		{
			return false;
		}

		public static bool QueryCommandState(string commandId)
		{
			return false;
		}

		public static bool QueryCommandSupported(string commandId)
		{
			return false;
		}

		public static string QueryCommandValue(string commandId)
		{
			return null;
		}

		[FieldProperty]
		public static string ReadyState
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static string Referrer
		{
			get {
				return null;
			}
		}

		public static object RegisterElement(string name)
		{
			return null;
		}

		public static object RegisterElement(string name, ElementRegistrationOptions options)
		{
			return null;
		}

		public static void ReleaseCapture()
		{
		}

		public static void ReleaseEvents()
		{
		}

		public static XmlNode RemoveChild(XmlNode child)
		{
			return default(XmlNode);
		}

		public static void RemoveEventListener(DocumentBaseEvents type, Action listener)
		{
		}

		public static void RemoveEventListener(DocumentBaseEvents type, Action listener, bool capture)
		{
		}

		public static void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener)
		{
		}

		public static void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public static void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener)
		{
		}

		public static void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture)
		{
		}

		public static void RemoveEventListener(DocumentBaseEvents type, IEventListener listener)
		{
		}

		public static void RemoveEventListener(DocumentBaseEvents type, IEventListener listener, bool capture)
		{
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, Action listener)
		{
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, Action listener, bool capture)
		{
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandler listener)
		{
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener)
		{
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture)
		{
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, IEventListener listener)
		{
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, IEventListener listener, bool capture)
		{
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener)
		{
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener)
		{
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener)
		{
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture)
		{
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture)
		{
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture)
		{
		}

		public static void RemoveEventListener(string type, IEventListener listener)
		{
		}

		public static void RemoveEventListener(string type, IEventListener listener, bool capture)
		{
		}

		public static void RemoveEventListener(XmlNodeEvents type, Action listener)
		{
		}

		public static void RemoveEventListener(XmlNodeEvents type, Action listener, bool capture)
		{
		}

		public static void RemoveEventListener(XmlNodeEvents type, HtmlEventHandler listener)
		{
		}

		public static void RemoveEventListener(XmlNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public static void RemoveEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener)
		{
		}

		public static void RemoveEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture)
		{
		}

		public static void RemoveEventListener(XmlNodeEvents type, IEventListener listener)
		{
		}

		public static void RemoveEventListener(XmlNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public static XmlNode ReplaceChild(XmlNode node, XmlNode child)
		{
			return default(XmlNode);
		}

		[FieldProperty]
		public static ElementCollection Scripts
		{
			get {
				return default(ElementCollection);
			}
		}

		[FieldProperty]
		public static string SelectedStyleSheetSet
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public static StyleSheetList StyleSheets
		{
			get {
				return default(StyleSheetList);
			}
		}

		[FieldProperty]
		public static DOMStringList StyleSheetSets
		{
			get {
				return default(DOMStringList);
			}
		}

		[Name("TEXT_NODE")]
		public const ushort TEXT_NODE = 3;

		[FieldProperty]
		public static string TextContent
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public static string Title
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public static string URL
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static VisibilityState VisibilityState
		{
			get {
				return default(VisibilityState);
			}
		}

		[FieldProperty]
		public static string VlinkColor
		{
			get {
				return null;
			}
			set {
			}
		}

		[ExpandParams]
		public static void Write(params string[] text)
		{
		}

		[ExpandParams]
		public static void Writeln(params string[] text)
		{
		}
	}
}
