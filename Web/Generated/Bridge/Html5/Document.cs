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
		public static extern void AddEventListener(DocumentBaseEvents type, Action listener);

		public static extern void AddEventListener(DocumentBaseEvents type, Action listener, bool capture);

		public static extern void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener);

		public static extern void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture);

		public static extern void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener);

		public static extern void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture);

		public static extern void AddEventListener(DocumentBaseEvents type, IEventListener listener);

		public static extern void AddEventListener(DocumentBaseEvents type, IEventListener listener, bool capture);

		public static extern void AddEventListener(DocumentInstanceEvents type, Action listener);

		public static extern void AddEventListener(DocumentInstanceEvents type, Action listener, bool capture);

		public static extern void AddEventListener(DocumentInstanceEvents type, HtmlEventHandler listener);

		public static extern void AddEventListener(DocumentInstanceEvents type, HtmlEventHandler listener, bool capture);

		public static extern void AddEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener);

		public static extern void AddEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture);

		public static extern void AddEventListener(DocumentInstanceEvents type, IEventListener listener);

		public static extern void AddEventListener(DocumentInstanceEvents type, IEventListener listener, bool capture);

		public static extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener);

		public static extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener);

		public static extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener);

		public static extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture);

		public static extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture);

		public static extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture);

		public static extern void AddEventListener(string type, IEventListener listener);

		public static extern void AddEventListener(string type, IEventListener listener, bool capture);

		public static extern void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted);

		public static extern void AddEventListener(XmlNodeEvents type, Action listener);

		public static extern void AddEventListener(XmlNodeEvents type, Action listener, bool capture);

		public static extern void AddEventListener(XmlNodeEvents type, HtmlEventHandler listener);

		public static extern void AddEventListener(XmlNodeEvents type, HtmlEventHandler listener, bool capture);

		public static extern void AddEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener);

		public static extern void AddEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture);

		public static extern void AddEventListener(XmlNodeEvents type, IEventListener listener);

		public static extern void AddEventListener(XmlNodeEvents type, IEventListener listener, bool capture);

		public static extern XmlNode AdoptNode(XmlNode node);

		[FieldProperty]
		public static extern string AlinkColor
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern object All
		{
			get;
		}

		[FieldProperty]
		public static extern ElementCollection Anchors
		{
			get;
		}

		public static extern XmlNode AppendChild(XmlNode node);

		[FieldProperty]
		public static extern ElementCollection Applets
		{
			get;
		}

		[Name("ATTRIBUTE_NODE")]
		public const ushort ATTRIBUTE_NODE = 2;

		[FieldProperty]
		public static extern string BaseURI
		{
			get;
		}

		[FieldProperty]
		public static extern string BgColor
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern Element Body
		{
			get;
			set;
		}

		public static extern void CaptureEvents();

		public static extern CaretPosition CaretPositionFromPoint(double x, double y);

		[Name("CDATA_SECTION_NODE")]
		public const ushort CDATA_SECTION_NODE = 4;

		[FieldProperty]
		public static extern string CharacterSet
		{
			get;
		}

		[FieldProperty]
		public static extern int ChildElementCount
		{
			get;
		}

		[FieldProperty]
		public static extern XmlNodeList ChildNodes
		{
			get;
		}

		public static extern void Clear();

		public static extern XmlNode CloneNode();

		public static extern XmlNode CloneNode(bool deep);

		public static extern void Close();

		[Name("COMMENT_NODE")]
		public const ushort COMMENT_NODE = 8;

		public static extern DocumentPosition CompareDocumentPosition(XmlNode other);

		[FieldProperty]
		public static extern string CompatMode
		{
			get;
		}

		public static extern bool Contains(XmlNode other);

		[FieldProperty]
		public static extern string ContentType
		{
			get;
		}

		public static extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from);

		public static extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public static extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from);

		public static extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public static extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from);

		public static extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		[FieldProperty]
		public static extern string Cookie
		{
			get;
			set;
		}

		public static extern XmlAttribute CreateAttribute(string name);

		public static extern XmlAttribute CreateAttributeNS(string @namespace, string name);

		public static extern XmlCDataSection CreateCDATASection(string data);

		public static extern XmlComment CreateComment(string data);

		public static extern XmlDocumentFragment CreateDocumentFragment();

		public static extern Event CreateEvent(string @interface);

		public static extern XPathExpression CreateExpression(string expression, XPathNSResolver resolver);

		public static extern NodeIterator CreateNodeIterator(XmlNode root);

		public static extern NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow);

		public static extern NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow, INodeFilter filter);

		public static extern XPathNSResolver CreateNSResolver(XmlNode nodeResolver);

		public static extern XmlProcessingInstruction CreateProcessingInstruction(string target, string data);

		public static extern Range CreateRange();

		public static extern XmlText CreateTextNode(string data);

		public static extern Touch CreateTouch();

		public static extern Touch CreateTouch(WindowInstance view);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, double rotationAngle);

		public static extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, double rotationAngle, double force);

		public static extern TouchList CreateTouchList();

		[ExpandParams]
		public static extern TouchList CreateTouchList(Touch touch, params Touch[] touches);

		public static extern TouchList CreateTouchList(Touch[] touches);

		public static extern TreeWalker CreateTreeWalker(XmlNode root);

		public static extern TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow);

		public static extern TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow, INodeFilter filter);

		[FieldProperty]
		public static extern WindowInstance DefaultView
		{
			get;
		}

		[FieldProperty]
		public static extern string DesignMode
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern string Dir
		{
			get;
			set;
		}

		public static extern bool DispatchEvent(Event @event);

		[FieldProperty]
		public static extern DocumentType Doctype
		{
			get;
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
		public static extern string DocumentURI
		{
			get;
		}

		[FieldProperty]
		public static extern string Domain
		{
			get;
			set;
		}

		[Name("ELEMENT_NODE")]
		public const ushort ELEMENT_NODE = 1;

		[FieldProperty]
		public static extern ElementCollection Embeds
		{
			get;
		}

		public static extern void EnableStyleSheetsForSet(string name);

		[Name("ENTITY_NODE")]
		public const ushort ENTITY_NODE = 6;

		[Name("ENTITY_REFERENCE_NODE")]
		public const ushort ENTITY_REFERENCE_NODE = 5;

		public static extern XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result);

		public static extern bool ExecCommand(string commandId);

		public static extern bool ExecCommand(string commandId, bool showUI);

		public static extern bool ExecCommand(string commandId, bool showUI, string value);

		[FieldProperty]
		public static extern string FgColor
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern XmlNode FirstChild
		{
			get;
		}

		[FieldProperty]
		public static extern ElementCollection Forms
		{
			get;
		}

		public static extern DOMQuad[] GetBoxQuads();

		public static extern DOMQuad[] GetBoxQuads(BoxQuadOptions options);

		public static extern ElementNodeList GetElementsByName(string elementName);

		public static extern ElementNodeList GetItems();

		public static extern ElementNodeList GetItems(string typeNames);

		public static extern Selection GetSelection();

		public static extern object GetUserData(string key);

		public static extern bool HasAttributes();

		public static extern bool HasChildNodes();

		public static extern bool HasFocus();

		[FieldProperty]
		public static extern HeadElement Head
		{
			get;
		}

		[FieldProperty]
		public static extern bool Hidden
		{
			get;
		}

		[FieldProperty]
		public static extern ElementCollection Images
		{
			get;
		}

		[FieldProperty]
		public static extern DOMImplementation Implementation
		{
			get;
		}

		public static extern XmlNode ImportNode(XmlNode node);

		public static extern XmlNode ImportNode(XmlNode node, bool deep);

		[FieldProperty]
		public static extern string InputEncoding
		{
			get;
		}

		public static extern XmlNode InsertBefore(XmlNode node, XmlNode child);

		public static extern bool IsDefaultNamespace(string @namespace);

		public static extern bool IsEqualNode(XmlNode node);

		[FieldProperty]
		public static extern XmlNode LastChild
		{
			get;
		}

		[FieldProperty]
		public static extern string LastModified
		{
			get;
		}

		[FieldProperty]
		public static extern string LastStyleSheetSet
		{
			get;
		}

		[FieldProperty]
		public static extern string LinkColor
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern ElementCollection Links
		{
			get;
		}

		[FieldProperty]
		public static extern string LocalName
		{
			get;
		}

		[FieldProperty]
		public static extern Location Location
		{
			get;
		}

		public static extern string LookupNamespaceURI(string prefix);

		public static extern string LookupPrefix(string @namespace);

		[FieldProperty]
		public static extern string NamespaceURI
		{
			get;
		}

		[FieldProperty]
		public static extern XmlNode NextSibling
		{
			get;
		}

		[FieldProperty]
		public static extern string NodeName
		{
			get;
		}

		[FieldProperty]
		public static extern XmlNodeType NodeType
		{
			get;
		}

		[FieldProperty]
		public static extern string NodeValue
		{
			get;
			set;
		}

		public static extern void Normalize();

		[Name("NOTATION_NODE")]
		public const ushort NOTATION_NODE = 12;

		[FieldProperty, Name("onabort")]
		public static extern HtmlEventHandler OnAbort
		{
			get;
			set;
		}

		[FieldProperty, Name("onafterscriptexecute")]
		public static extern HtmlEventHandler OnAfterscriptexecute
		{
			get;
			set;
		}

		[FieldProperty, Name("onbeforescriptexecute")]
		public static extern HtmlEventHandler OnBeforescriptexecute
		{
			get;
			set;
		}

		[FieldProperty, Name("onblur")]
		public static extern HtmlEventHandler OnBlur
		{
			get;
			set;
		}

		[FieldProperty, Name("oncanplay")]
		public static extern HtmlEventHandler OnCanplay
		{
			get;
			set;
		}

		[FieldProperty, Name("oncanplaythrough")]
		public static extern HtmlEventHandler OnCanplaythrough
		{
			get;
			set;
		}

		[FieldProperty, Name("onchange")]
		public static extern HtmlEventHandler OnChange
		{
			get;
			set;
		}

		[FieldProperty, Name("onclick")]
		public static extern HtmlEventHandler OnClick
		{
			get;
			set;
		}

		[FieldProperty, Name("oncontextmenu")]
		public static extern HtmlEventHandler OnContextmenu
		{
			get;
			set;
		}

		[FieldProperty, Name("oncopy")]
		public static extern HtmlEventHandler OnCopy
		{
			get;
			set;
		}

		[FieldProperty, Name("oncut")]
		public static extern HtmlEventHandler OnCut
		{
			get;
			set;
		}

		[FieldProperty, Name("ondblclick")]
		public static extern HtmlEventHandler OnDblclick
		{
			get;
			set;
		}

		[FieldProperty, Name("ondrag")]
		public static extern HtmlEventHandler OnDrag
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragend")]
		public static extern HtmlEventHandler OnDragend
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragenter")]
		public static extern HtmlEventHandler OnDragenter
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragleave")]
		public static extern HtmlEventHandler OnDragleave
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragover")]
		public static extern HtmlEventHandler OnDragover
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragstart")]
		public static extern HtmlEventHandler OnDragstart
		{
			get;
			set;
		}

		[FieldProperty, Name("ondrop")]
		public static extern HtmlEventHandler OnDrop
		{
			get;
			set;
		}

		[FieldProperty, Name("ondurationchange")]
		public static extern HtmlEventHandler OnDurationchange
		{
			get;
			set;
		}

		[FieldProperty, Name("onemptied")]
		public static extern HtmlEventHandler OnEmptied
		{
			get;
			set;
		}

		[FieldProperty, Name("onended")]
		public static extern HtmlEventHandler OnEnded
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public static extern HtmlEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onfocus")]
		public static extern HtmlEventHandler OnFocus
		{
			get;
			set;
		}

		[FieldProperty, Name("oninput")]
		public static extern HtmlEventHandler OnInput
		{
			get;
			set;
		}

		[FieldProperty, Name("oninvalid")]
		public static extern HtmlEventHandler OnInvalid
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeydown")]
		public static extern HtmlEventHandler OnKeydown
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeypress")]
		public static extern HtmlEventHandler OnKeypress
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeyup")]
		public static extern HtmlEventHandler OnKeyup
		{
			get;
			set;
		}

		[FieldProperty, Name("onload")]
		public static extern HtmlEventHandler OnLoad
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadeddata")]
		public static extern HtmlEventHandler OnLoadeddata
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadedmetadata")]
		public static extern HtmlEventHandler OnLoadedmetadata
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadstart")]
		public static extern HtmlEventHandler OnLoadstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onmousedown")]
		public static extern HtmlEventHandler OnMousedown
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseenter")]
		public static extern HtmlEventHandler OnMouseenter
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseleave")]
		public static extern HtmlEventHandler OnMouseleave
		{
			get;
			set;
		}

		[FieldProperty, Name("onmousemove")]
		public static extern HtmlEventHandler OnMousemove
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseout")]
		public static extern HtmlEventHandler OnMouseout
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseover")]
		public static extern HtmlEventHandler OnMouseover
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseup")]
		public static extern HtmlEventHandler OnMouseup
		{
			get;
			set;
		}

		[FieldProperty, Name("onpaste")]
		public static extern HtmlEventHandler OnPaste
		{
			get;
			set;
		}

		[FieldProperty, Name("onpause")]
		public static extern HtmlEventHandler OnPause
		{
			get;
			set;
		}

		[FieldProperty, Name("onplay")]
		public static extern HtmlEventHandler OnPlay
		{
			get;
			set;
		}

		[FieldProperty, Name("onplaying")]
		public static extern HtmlEventHandler OnPlaying
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointercancel")]
		public static extern HtmlEventHandler OnPointercancel
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerdown")]
		public static extern HtmlEventHandler OnPointerdown
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerenter")]
		public static extern HtmlEventHandler OnPointerenter
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerleave")]
		public static extern HtmlEventHandler OnPointerleave
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointermove")]
		public static extern HtmlEventHandler OnPointermove
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerout")]
		public static extern HtmlEventHandler OnPointerout
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerover")]
		public static extern HtmlEventHandler OnPointerover
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerup")]
		public static extern HtmlEventHandler OnPointerup
		{
			get;
			set;
		}

		[FieldProperty, Name("onprogress")]
		public static extern HtmlEventHandler OnProgress
		{
			get;
			set;
		}

		[FieldProperty, Name("onratechange")]
		public static extern HtmlEventHandler OnRatechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onreadystatechange")]
		public static extern HtmlEventHandler OnReadystatechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onreset")]
		public static extern HtmlEventHandler OnReset
		{
			get;
			set;
		}

		[FieldProperty, Name("onscroll")]
		public static extern HtmlEventHandler OnScroll
		{
			get;
			set;
		}

		[FieldProperty, Name("onseeked")]
		public static extern HtmlEventHandler OnSeeked
		{
			get;
			set;
		}

		[FieldProperty, Name("onseeking")]
		public static extern HtmlEventHandler OnSeeking
		{
			get;
			set;
		}

		[FieldProperty, Name("onselect")]
		public static extern HtmlEventHandler OnSelect
		{
			get;
			set;
		}

		[FieldProperty, Name("onshow")]
		public static extern HtmlEventHandler OnShow
		{
			get;
			set;
		}

		[FieldProperty, Name("onstalled")]
		public static extern HtmlEventHandler OnStalled
		{
			get;
			set;
		}

		[FieldProperty, Name("onsubmit")]
		public static extern HtmlEventHandler OnSubmit
		{
			get;
			set;
		}

		[FieldProperty, Name("onsuspend")]
		public static extern HtmlEventHandler OnSuspend
		{
			get;
			set;
		}

		[FieldProperty, Name("ontimeupdate")]
		public static extern HtmlEventHandler OnTimeupdate
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchcancel")]
		public static extern HtmlEventHandler OnTouchcancel
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchend")]
		public static extern HtmlEventHandler OnTouchend
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchenter")]
		public static extern HtmlEventHandler OnTouchenter
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchleave")]
		public static extern HtmlEventHandler OnTouchleave
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchmove")]
		public static extern HtmlEventHandler OnTouchmove
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchstart")]
		public static extern HtmlEventHandler OnTouchstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onvolumechange")]
		public static extern HtmlEventHandler OnVolumechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onwaiting")]
		public static extern HtmlEventHandler OnWaiting
		{
			get;
			set;
		}

		[FieldProperty, Name("onwheel")]
		public static extern HtmlEventHandler OnWheel
		{
			get;
			set;
		}

		public static extern DocumentBase Open();

		public static extern DocumentBase Open(string type);

		public static extern DocumentBase Open(string type, string replace);

		public static extern WindowInstance Open(string url, string name, string features);

		public static extern WindowInstance Open(string url, string name, string features, bool replace);

		[FieldProperty]
		public static extern DocumentBase OwnerDocument
		{
			get;
		}

		[FieldProperty]
		public static extern XmlNode ParentNode
		{
			get;
		}

		[FieldProperty]
		public static extern ElementCollection Plugins
		{
			get;
		}

		[FieldProperty]
		public static extern string PreferredStyleSheetSet
		{
			get;
		}

		[FieldProperty]
		public static extern string Prefix
		{
			get;
		}

		[FieldProperty]
		public static extern XmlNode PreviousSibling
		{
			get;
		}

		[Name("PROCESSING_INSTRUCTION_NODE")]
		public const ushort PROCESSING_INSTRUCTION_NODE = 7;

		public static extern bool QueryCommandEnabled(string commandId);

		public static extern bool QueryCommandIndeterm(string commandId);

		public static extern bool QueryCommandState(string commandId);

		public static extern bool QueryCommandSupported(string commandId);

		public static extern string QueryCommandValue(string commandId);

		[FieldProperty]
		public static extern string ReadyState
		{
			get;
		}

		[FieldProperty]
		public static extern string Referrer
		{
			get;
		}

		public static extern object RegisterElement(string name);

		public static extern object RegisterElement(string name, ElementRegistrationOptions options);

		public static extern void ReleaseCapture();

		public static extern void ReleaseEvents();

		public static extern XmlNode RemoveChild(XmlNode child);

		public static extern void RemoveEventListener(DocumentBaseEvents type, Action listener);

		public static extern void RemoveEventListener(DocumentBaseEvents type, Action listener, bool capture);

		public static extern void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener);

		public static extern void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture);

		public static extern void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener);

		public static extern void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture);

		public static extern void RemoveEventListener(DocumentBaseEvents type, IEventListener listener);

		public static extern void RemoveEventListener(DocumentBaseEvents type, IEventListener listener, bool capture);

		public static extern void RemoveEventListener(DocumentInstanceEvents type, Action listener);

		public static extern void RemoveEventListener(DocumentInstanceEvents type, Action listener, bool capture);

		public static extern void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandler listener);

		public static extern void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandler listener, bool capture);

		public static extern void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener);

		public static extern void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture);

		public static extern void RemoveEventListener(DocumentInstanceEvents type, IEventListener listener);

		public static extern void RemoveEventListener(DocumentInstanceEvents type, IEventListener listener, bool capture);

		public static extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener);

		public static extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener);

		public static extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener);

		public static extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture);

		public static extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture);

		public static extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture);

		public static extern void RemoveEventListener(string type, IEventListener listener);

		public static extern void RemoveEventListener(string type, IEventListener listener, bool capture);

		public static extern void RemoveEventListener(XmlNodeEvents type, Action listener);

		public static extern void RemoveEventListener(XmlNodeEvents type, Action listener, bool capture);

		public static extern void RemoveEventListener(XmlNodeEvents type, HtmlEventHandler listener);

		public static extern void RemoveEventListener(XmlNodeEvents type, HtmlEventHandler listener, bool capture);

		public static extern void RemoveEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener);

		public static extern void RemoveEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture);

		public static extern void RemoveEventListener(XmlNodeEvents type, IEventListener listener);

		public static extern void RemoveEventListener(XmlNodeEvents type, IEventListener listener, bool capture);

		public static extern XmlNode ReplaceChild(XmlNode node, XmlNode child);

		[FieldProperty]
		public static extern ElementCollection Scripts
		{
			get;
		}

		[FieldProperty]
		public static extern string SelectedStyleSheetSet
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern StyleSheetList StyleSheets
		{
			get;
		}

		[FieldProperty]
		public static extern DOMStringList StyleSheetSets
		{
			get;
		}

		[Name("TEXT_NODE")]
		public const ushort TEXT_NODE = 3;

		[FieldProperty]
		public static extern string TextContent
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern string Title
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern string URL
		{
			get;
		}

		[FieldProperty]
		public static extern VisibilityState VisibilityState
		{
			get;
		}

		[FieldProperty]
		public static extern string VlinkColor
		{
			get;
			set;
		}

		[ExpandParams]
		public static extern void Write(params string[] text);

		[ExpandParams]
		public static extern void Writeln(params string[] text);
	}
}
