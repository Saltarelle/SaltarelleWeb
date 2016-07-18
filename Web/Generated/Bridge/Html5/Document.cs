using Bridge.Html5.Editing;
using Bridge.Html5.WebComponents;
using Bridge.Html5.Xml;
using Bridge.Html5.Xml.XPath;
using System;

namespace Bridge.Html5
{
	[External, Namespace(false), Name("document")]
	public static partial class Document
	{
		public static readonly XmlElement ActiveElement;

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

		public static string AlinkColor;

		public static readonly object All;

		public static readonly ElementCollection Anchors;

		public static extern XmlNode AppendChild(XmlNode node);

		public static readonly ElementCollection Applets;

		[Name("ATTRIBUTE_NODE")]
		public const ushort ATTRIBUTE_NODE = 2;

		public static readonly string BaseURI;

		public static string BgColor;

		public static Element Body;

		public static extern void CaptureEvents();

		public static extern CaretPosition CaretPositionFromPoint(double x, double y);

		[Name("CDATA_SECTION_NODE")]
		public const ushort CDATA_SECTION_NODE = 4;

		public static readonly string CharacterSet;

		public static readonly int ChildElementCount;

		public static readonly XmlNodeList ChildNodes;

		public static readonly XmlElementCollection Children;

		public static extern void Clear();

		public static extern XmlNode CloneNode();

		public static extern XmlNode CloneNode(bool deep);

		public static extern void Close();

		[Name("COMMENT_NODE")]
		public const ushort COMMENT_NODE = 8;

		public static extern DocumentPosition CompareDocumentPosition(XmlNode other);

		public static readonly string CompatMode;

		public static extern bool Contains(XmlNode other);

		public static readonly string ContentType;

		public static extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from);

		public static extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public static extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from);

		public static extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public static extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from);

		public static extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public static string Cookie;

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

		public static readonly XmlElement CurrentScript;

		public static readonly WindowInstance DefaultView;

		public static string DesignMode;

		public static string Dir;

		public static extern bool DispatchEvent(Event @event);

		public static readonly DocumentType Doctype;

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

		public static readonly XmlElement DocumentElement;

		public static readonly string DocumentURI;

		public static string Domain;

		[Name("ELEMENT_NODE")]
		public const ushort ELEMENT_NODE = 1;

		public static readonly ElementCollection Embeds;

		public static extern void EnableStyleSheetsForSet(string name);

		[Name("ENTITY_NODE")]
		public const ushort ENTITY_NODE = 6;

		[Name("ENTITY_REFERENCE_NODE")]
		public const ushort ENTITY_REFERENCE_NODE = 5;

		public static extern XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result);

		public static extern bool ExecCommand(string commandId);

		public static extern bool ExecCommand(string commandId, bool showUI);

		public static extern bool ExecCommand(string commandId, bool showUI, string value);

		public static string FgColor;

		public static readonly XmlNode FirstChild;

		public static readonly XmlElement FirstElementChild;

		public static readonly ElementCollection Forms;

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

		public static readonly HeadElement Head;

		public static readonly bool Hidden;

		public static readonly ElementCollection Images;

		public static readonly DOMImplementation Implementation;

		public static extern XmlNode ImportNode(XmlNode node);

		public static extern XmlNode ImportNode(XmlNode node, bool deep);

		public static readonly string InputEncoding;

		public static extern XmlNode InsertBefore(XmlNode node, XmlNode child);

		public static extern bool IsDefaultNamespace(string @namespace);

		public static extern bool IsEqualNode(XmlNode node);

		public static readonly XmlNode LastChild;

		public static readonly XmlElement LastElementChild;

		public static readonly string LastModified;

		public static readonly string LastStyleSheetSet;

		public static string LinkColor;

		public static readonly ElementCollection Links;

		public static readonly string LocalName;

		public static readonly Location Location;

		public static extern string LookupNamespaceURI(string prefix);

		public static extern string LookupPrefix(string @namespace);

		public static readonly string NamespaceURI;

		public static readonly XmlNode NextSibling;

		public static readonly string NodeName;

		public static readonly XmlNodeType NodeType;

		public static string NodeValue;

		public static extern void Normalize();

		[Name("NOTATION_NODE")]
		public const ushort NOTATION_NODE = 12;

		[Name("onabort")]
		public static HtmlEventHandler OnAbort;

		[Name("onafterscriptexecute")]
		public static HtmlEventHandler OnAfterscriptexecute;

		[Name("onbeforescriptexecute")]
		public static HtmlEventHandler OnBeforescriptexecute;

		[Name("onblur")]
		public static HtmlEventHandler OnBlur;

		[Name("oncanplay")]
		public static HtmlEventHandler OnCanplay;

		[Name("oncanplaythrough")]
		public static HtmlEventHandler OnCanplaythrough;

		[Name("onchange")]
		public static HtmlEventHandler OnChange;

		[Name("onclick")]
		public static HtmlEventHandler OnClick;

		[Name("oncontextmenu")]
		public static HtmlEventHandler OnContextmenu;

		[Name("oncopy")]
		public static HtmlEventHandler OnCopy;

		[Name("oncut")]
		public static HtmlEventHandler OnCut;

		[Name("ondblclick")]
		public static HtmlEventHandler OnDblclick;

		[Name("ondrag")]
		public static HtmlEventHandler OnDrag;

		[Name("ondragend")]
		public static HtmlEventHandler OnDragend;

		[Name("ondragenter")]
		public static HtmlEventHandler OnDragenter;

		[Name("ondragleave")]
		public static HtmlEventHandler OnDragleave;

		[Name("ondragover")]
		public static HtmlEventHandler OnDragover;

		[Name("ondragstart")]
		public static HtmlEventHandler OnDragstart;

		[Name("ondrop")]
		public static HtmlEventHandler OnDrop;

		[Name("ondurationchange")]
		public static HtmlEventHandler OnDurationchange;

		[Name("onemptied")]
		public static HtmlEventHandler OnEmptied;

		[Name("onended")]
		public static HtmlEventHandler OnEnded;

		[Name("onerror")]
		public static HtmlEventHandler OnError;

		[Name("onfocus")]
		public static HtmlEventHandler OnFocus;

		[Name("oninput")]
		public static HtmlEventHandler OnInput;

		[Name("oninvalid")]
		public static HtmlEventHandler OnInvalid;

		[Name("onkeydown")]
		public static HtmlEventHandler OnKeydown;

		[Name("onkeypress")]
		public static HtmlEventHandler OnKeypress;

		[Name("onkeyup")]
		public static HtmlEventHandler OnKeyup;

		[Name("onload")]
		public static HtmlEventHandler OnLoad;

		[Name("onloadeddata")]
		public static HtmlEventHandler OnLoadeddata;

		[Name("onloadedmetadata")]
		public static HtmlEventHandler OnLoadedmetadata;

		[Name("onloadstart")]
		public static HtmlEventHandler OnLoadstart;

		[Name("onmousedown")]
		public static HtmlEventHandler OnMousedown;

		[Name("onmouseenter")]
		public static HtmlEventHandler OnMouseenter;

		[Name("onmouseleave")]
		public static HtmlEventHandler OnMouseleave;

		[Name("onmousemove")]
		public static HtmlEventHandler OnMousemove;

		[Name("onmouseout")]
		public static HtmlEventHandler OnMouseout;

		[Name("onmouseover")]
		public static HtmlEventHandler OnMouseover;

		[Name("onmouseup")]
		public static HtmlEventHandler OnMouseup;

		[Name("onpaste")]
		public static HtmlEventHandler OnPaste;

		[Name("onpause")]
		public static HtmlEventHandler OnPause;

		[Name("onplay")]
		public static HtmlEventHandler OnPlay;

		[Name("onplaying")]
		public static HtmlEventHandler OnPlaying;

		[Name("onpointercancel")]
		public static HtmlEventHandler OnPointercancel;

		[Name("onpointerdown")]
		public static HtmlEventHandler OnPointerdown;

		[Name("onpointerenter")]
		public static HtmlEventHandler OnPointerenter;

		[Name("onpointerleave")]
		public static HtmlEventHandler OnPointerleave;

		[Name("onpointermove")]
		public static HtmlEventHandler OnPointermove;

		[Name("onpointerout")]
		public static HtmlEventHandler OnPointerout;

		[Name("onpointerover")]
		public static HtmlEventHandler OnPointerover;

		[Name("onpointerup")]
		public static HtmlEventHandler OnPointerup;

		[Name("onprogress")]
		public static HtmlEventHandler OnProgress;

		[Name("onratechange")]
		public static HtmlEventHandler OnRatechange;

		[Name("onreadystatechange")]
		public static HtmlEventHandler OnReadystatechange;

		[Name("onreset")]
		public static HtmlEventHandler OnReset;

		[Name("onscroll")]
		public static HtmlEventHandler OnScroll;

		[Name("onseeked")]
		public static HtmlEventHandler OnSeeked;

		[Name("onseeking")]
		public static HtmlEventHandler OnSeeking;

		[Name("onselect")]
		public static HtmlEventHandler OnSelect;

		[Name("onshow")]
		public static HtmlEventHandler OnShow;

		[Name("onstalled")]
		public static HtmlEventHandler OnStalled;

		[Name("onsubmit")]
		public static HtmlEventHandler OnSubmit;

		[Name("onsuspend")]
		public static HtmlEventHandler OnSuspend;

		[Name("ontimeupdate")]
		public static HtmlEventHandler OnTimeupdate;

		[Name("ontouchcancel")]
		public static HtmlEventHandler OnTouchcancel;

		[Name("ontouchend")]
		public static HtmlEventHandler OnTouchend;

		[Name("ontouchenter")]
		public static HtmlEventHandler OnTouchenter;

		[Name("ontouchleave")]
		public static HtmlEventHandler OnTouchleave;

		[Name("ontouchmove")]
		public static HtmlEventHandler OnTouchmove;

		[Name("ontouchstart")]
		public static HtmlEventHandler OnTouchstart;

		[Name("onvolumechange")]
		public static HtmlEventHandler OnVolumechange;

		[Name("onwaiting")]
		public static HtmlEventHandler OnWaiting;

		[Name("onwheel")]
		public static HtmlEventHandler OnWheel;

		public static extern DocumentBase Open();

		public static extern DocumentBase Open(string type);

		public static extern DocumentBase Open(string type, string replace);

		public static extern WindowInstance Open(string url, string name, string features);

		public static extern WindowInstance Open(string url, string name, string features, bool replace);

		public static readonly DocumentBase OwnerDocument;

		public static readonly XmlElement ParentElement;

		public static readonly XmlNode ParentNode;

		public static readonly ElementCollection Plugins;

		public static readonly string PreferredStyleSheetSet;

		public static readonly string Prefix;

		public static readonly XmlNode PreviousSibling;

		[Name("PROCESSING_INSTRUCTION_NODE")]
		public const ushort PROCESSING_INSTRUCTION_NODE = 7;

		public static extern bool QueryCommandEnabled(string commandId);

		public static extern bool QueryCommandIndeterm(string commandId);

		public static extern bool QueryCommandState(string commandId);

		public static extern bool QueryCommandSupported(string commandId);

		public static extern string QueryCommandValue(string commandId);

		public static readonly string ReadyState;

		public static readonly string Referrer;

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

		public static readonly ElementCollection Scripts;

		public static string SelectedStyleSheetSet;

		public static readonly StyleSheetList StyleSheets;

		public static readonly DOMStringList StyleSheetSets;

		[Name("TEXT_NODE")]
		public const ushort TEXT_NODE = 3;

		public static string TextContent;

		public static string Title;

		public static readonly string URL;

		public static readonly VisibilityState VisibilityState;

		public static string VlinkColor;

		[ExpandParams]
		public static extern void Write(params string[] text);

		[ExpandParams]
		public static extern void Writeln(params string[] text);
	}
}
