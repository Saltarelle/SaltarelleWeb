using Bridge.Html5.Editing;
using Bridge.Html5.WebComponents;
using Bridge.Html5.Xml.XPath;
using System;

namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Document")]
	public partial class DocumentBase : XmlNode, IXPathEvaluator, IGeometryUtils
	{
		public DocumentBase()
		{
		}

		[FieldProperty]
		public XmlElement ActiveElement
		{
			get {
				return default(XmlElement);
			}
		}

		public void AddEventListener(DocumentBaseEvents type, Action listener)
		{
		}

		public void AddEventListener(DocumentBaseEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener)
		{
		}

		public void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture)
		{
		}

		public void AddEventListener(DocumentBaseEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(DocumentBaseEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture)
		{
		}

		public XmlNode AdoptNode(XmlNode node)
		{
			return default(XmlNode);
		}

		public CaretPosition CaretPositionFromPoint(double x, double y)
		{
			return default(CaretPosition);
		}

		[FieldProperty]
		public string CharacterSet
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public int ChildElementCount
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public XmlElementCollection Children
		{
			get {
				return default(XmlElementCollection);
			}
		}

		[FieldProperty]
		public string CompatMode
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string ContentType
		{
			get {
				return null;
			}
		}

		public DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from)
		{
			return default(DOMPoint);
		}

		public DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options)
		{
			return default(DOMPoint);
		}

		public DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from)
		{
			return default(DOMQuad);
		}

		public DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options)
		{
			return default(DOMQuad);
		}

		public DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from)
		{
			return default(DOMQuad);
		}

		public DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options)
		{
			return default(DOMQuad);
		}

		public XmlAttribute CreateAttribute(string name)
		{
			return default(XmlAttribute);
		}

		public XmlAttribute CreateAttributeNS(string @namespace, string name)
		{
			return default(XmlAttribute);
		}

		public XmlCDataSection CreateCDATASection(string data)
		{
			return default(XmlCDataSection);
		}

		public XmlComment CreateComment(string data)
		{
			return default(XmlComment);
		}

		public XmlDocumentFragment CreateDocumentFragment()
		{
			return default(XmlDocumentFragment);
		}

		public XmlElement CreateElement(string localName)
		{
			return default(XmlElement);
		}

		public XmlElement CreateElement(string localName, string typeExtension)
		{
			return default(XmlElement);
		}

		public XmlElement CreateElementNS(string @namespace, string qualifiedName)
		{
			return default(XmlElement);
		}

		public XmlElement CreateElementNS(string @namespace, string qualifiedName, string typeExtension)
		{
			return default(XmlElement);
		}

		public Event CreateEvent(string @interface)
		{
			return default(Event);
		}

		public XPathExpression CreateExpression(string expression, XPathNSResolver resolver)
		{
			return default(XPathExpression);
		}

		public NodeIterator CreateNodeIterator(XmlNode root)
		{
			return default(NodeIterator);
		}

		public NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow)
		{
			return default(NodeIterator);
		}

		public NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow, INodeFilter filter)
		{
			return default(NodeIterator);
		}

		public XPathNSResolver CreateNSResolver(XmlNode nodeResolver)
		{
			return default(XPathNSResolver);
		}

		public XmlProcessingInstruction CreateProcessingInstruction(string target, string data)
		{
			return default(XmlProcessingInstruction);
		}

		public Range CreateRange()
		{
			return default(Range);
		}

		public XmlText CreateTextNode(string data)
		{
			return default(XmlText);
		}

		public Touch CreateTouch()
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, double rotationAngle)
		{
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, double rotationAngle, double force)
		{
			return default(Touch);
		}

		public TouchList CreateTouchList()
		{
			return default(TouchList);
		}

		[ExpandParams]
		public TouchList CreateTouchList(Touch touch, params Touch[] touches)
		{
			return default(TouchList);
		}

		public TouchList CreateTouchList(Touch[] touches)
		{
			return default(TouchList);
		}

		public TreeWalker CreateTreeWalker(XmlNode root)
		{
			return default(TreeWalker);
		}

		public TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow)
		{
			return default(TreeWalker);
		}

		public TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow, INodeFilter filter)
		{
			return default(TreeWalker);
		}

		[FieldProperty]
		public XmlElement CurrentScript
		{
			get {
				return default(XmlElement);
			}
		}

		[FieldProperty]
		public WindowInstance DefaultView
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public string Dir
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public DocumentType Doctype
		{
			get {
				return default(DocumentType);
			}
		}

		[FieldProperty]
		public XmlElement DocumentElement
		{
			get {
				return default(XmlElement);
			}
		}

		[FieldProperty]
		public string DocumentURI
		{
			get {
				return null;
			}
		}

		public XmlElement ElementFromPoint(double x, double y)
		{
			return default(XmlElement);
		}

		public void EnableStyleSheetsForSet(string name)
		{
		}

		public XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result)
		{
			return default(XPathResult);
		}

		[FieldProperty]
		public XmlElement FirstElementChild
		{
			get {
				return default(XmlElement);
			}
		}

		public DOMQuad[] GetBoxQuads()
		{
			return null;
		}

		public DOMQuad[] GetBoxQuads(BoxQuadOptions options)
		{
			return null;
		}

		public XmlElement GetElementById(string elementId)
		{
			return default(XmlElement);
		}

		public XmlElementCollection GetElementsByClassName(string classNames)
		{
			return default(XmlElementCollection);
		}

		public XmlElementCollection GetElementsByTagName(string localName)
		{
			return default(XmlElementCollection);
		}

		public XmlElementCollection GetElementsByTagNameNS(string @namespace, string localName)
		{
			return default(XmlElementCollection);
		}

		public bool HasFocus()
		{
			return false;
		}

		[FieldProperty]
		public bool Hidden
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public DOMImplementation Implementation
		{
			get {
				return default(DOMImplementation);
			}
		}

		public XmlNode ImportNode(XmlNode node)
		{
			return default(XmlNode);
		}

		public XmlNode ImportNode(XmlNode node, bool deep)
		{
			return default(XmlNode);
		}

		[FieldProperty]
		public string InputEncoding
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public XmlElement LastElementChild
		{
			get {
				return default(XmlElement);
			}
		}

		[FieldProperty]
		public string LastModified
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string LastStyleSheetSet
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public Location Location
		{
			get {
				return default(Location);
			}
		}

		[FieldProperty, Name("onabort")]
		public HtmlEventHandler OnAbort
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onafterscriptexecute")]
		public HtmlEventHandler OnAfterscriptexecute
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onbeforescriptexecute")]
		public HtmlEventHandler OnBeforescriptexecute
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onblur")]
		public HtmlEventHandler OnBlur
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncanplay")]
		public HtmlEventHandler OnCanplay
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncanplaythrough")]
		public HtmlEventHandler OnCanplaythrough
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onchange")]
		public HtmlEventHandler OnChange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onclick")]
		public HtmlEventHandler OnClick
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncontextmenu")]
		public HtmlEventHandler OnContextmenu
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncopy")]
		public HtmlEventHandler OnCopy
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncut")]
		public HtmlEventHandler OnCut
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondblclick")]
		public HtmlEventHandler OnDblclick
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondrag")]
		public HtmlEventHandler OnDrag
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragend")]
		public HtmlEventHandler OnDragend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragenter")]
		public HtmlEventHandler OnDragenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragleave")]
		public HtmlEventHandler OnDragleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragover")]
		public HtmlEventHandler OnDragover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragstart")]
		public HtmlEventHandler OnDragstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondrop")]
		public HtmlEventHandler OnDrop
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondurationchange")]
		public HtmlEventHandler OnDurationchange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onemptied")]
		public HtmlEventHandler OnEmptied
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onended")]
		public HtmlEventHandler OnEnded
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onerror")]
		public HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onfocus")]
		public HtmlEventHandler OnFocus
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oninput")]
		public HtmlEventHandler OnInput
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oninvalid")]
		public HtmlEventHandler OnInvalid
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeydown")]
		public HtmlEventHandler OnKeydown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeypress")]
		public HtmlEventHandler OnKeypress
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeyup")]
		public HtmlEventHandler OnKeyup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onload")]
		public HtmlEventHandler OnLoad
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadeddata")]
		public HtmlEventHandler OnLoadeddata
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadedmetadata")]
		public HtmlEventHandler OnLoadedmetadata
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadstart")]
		public HtmlEventHandler OnLoadstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmousedown")]
		public HtmlEventHandler OnMousedown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseenter")]
		public HtmlEventHandler OnMouseenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseleave")]
		public HtmlEventHandler OnMouseleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmousemove")]
		public HtmlEventHandler OnMousemove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseout")]
		public HtmlEventHandler OnMouseout
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseover")]
		public HtmlEventHandler OnMouseover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseup")]
		public HtmlEventHandler OnMouseup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpaste")]
		public HtmlEventHandler OnPaste
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpause")]
		public HtmlEventHandler OnPause
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onplay")]
		public HtmlEventHandler OnPlay
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onplaying")]
		public HtmlEventHandler OnPlaying
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointercancel")]
		public HtmlEventHandler OnPointercancel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerdown")]
		public HtmlEventHandler OnPointerdown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerenter")]
		public HtmlEventHandler OnPointerenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerleave")]
		public HtmlEventHandler OnPointerleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointermove")]
		public HtmlEventHandler OnPointermove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerout")]
		public HtmlEventHandler OnPointerout
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerover")]
		public HtmlEventHandler OnPointerover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerup")]
		public HtmlEventHandler OnPointerup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onprogress")]
		public HtmlEventHandler OnProgress
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onratechange")]
		public HtmlEventHandler OnRatechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onreadystatechange")]
		public HtmlEventHandler OnReadystatechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onreset")]
		public HtmlEventHandler OnReset
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onscroll")]
		public HtmlEventHandler OnScroll
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onseeked")]
		public HtmlEventHandler OnSeeked
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onseeking")]
		public HtmlEventHandler OnSeeking
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onselect")]
		public HtmlEventHandler OnSelect
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onshow")]
		public HtmlEventHandler OnShow
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onstalled")]
		public HtmlEventHandler OnStalled
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsubmit")]
		public HtmlEventHandler OnSubmit
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsuspend")]
		public HtmlEventHandler OnSuspend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontimeupdate")]
		public HtmlEventHandler OnTimeupdate
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchcancel")]
		public HtmlEventHandler OnTouchcancel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchend")]
		public HtmlEventHandler OnTouchend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchenter")]
		public HtmlEventHandler OnTouchenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchleave")]
		public HtmlEventHandler OnTouchleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchmove")]
		public HtmlEventHandler OnTouchmove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchstart")]
		public HtmlEventHandler OnTouchstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onvolumechange")]
		public HtmlEventHandler OnVolumechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onwaiting")]
		public HtmlEventHandler OnWaiting
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onwheel")]
		public HtmlEventHandler OnWheel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty]
		public string PreferredStyleSheetSet
		{
			get {
				return null;
			}
		}

		public XmlElement QuerySelector(string selectors)
		{
			return default(XmlElement);
		}

		public XmlNodeList QuerySelectorAll(string selectors)
		{
			return default(XmlNodeList);
		}

		[FieldProperty]
		public string ReadyState
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Referrer
		{
			get {
				return null;
			}
		}

		public object RegisterElement(string name)
		{
			return null;
		}

		public object RegisterElement(string name, ElementRegistrationOptions options)
		{
			return null;
		}

		public void ReleaseCapture()
		{
		}

		public void RemoveEventListener(DocumentBaseEvents type, Action listener)
		{
		}

		public void RemoveEventListener(DocumentBaseEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener)
		{
		}

		public void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture)
		{
		}

		public void RemoveEventListener(DocumentBaseEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(DocumentBaseEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture)
		{
		}

		[FieldProperty]
		public string SelectedStyleSheetSet
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public StyleSheetList StyleSheets
		{
			get {
				return default(StyleSheetList);
			}
		}

		[FieldProperty]
		public DOMStringList StyleSheetSets
		{
			get {
				return default(DOMStringList);
			}
		}

		[FieldProperty]
		public string Title
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string URL
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public VisibilityState VisibilityState
		{
			get {
				return default(VisibilityState);
			}
		}
	}
}
