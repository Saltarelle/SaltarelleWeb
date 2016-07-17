using Bridge.Html5.Editing;
using Bridge.Html5.WebComponents;
using Bridge.Html5.Xml.XPath;
using System;

namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Document")]
	public partial class DocumentBase : XmlNode, IXPathEvaluator, IGeometryUtils
	{
		public extern DocumentBase();

		public readonly XmlElement ActiveElement;

		public extern void AddEventListener(DocumentBaseEvents type, Action listener);

		public extern void AddEventListener(DocumentBaseEvents type, Action listener, bool capture);

		public extern void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener);

		public extern void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture);

		public extern void AddEventListener(DocumentBaseEvents type, IEventListener listener);

		public extern void AddEventListener(DocumentBaseEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture);

		public extern XmlNode AdoptNode(XmlNode node);

		public extern CaretPosition CaretPositionFromPoint(double x, double y);

		public readonly string CharacterSet;

		public readonly int ChildElementCount;

		public readonly XmlElementCollection Children;

		public readonly string CompatMode;

		public readonly string ContentType;

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern XmlAttribute CreateAttribute(string name);

		public extern XmlAttribute CreateAttributeNS(string @namespace, string name);

		public extern XmlCDataSection CreateCDATASection(string data);

		public extern XmlComment CreateComment(string data);

		public extern XmlDocumentFragment CreateDocumentFragment();

		public extern XmlElement CreateElement(string localName);

		public extern XmlElement CreateElement(string localName, string typeExtension);

		public extern XmlElement CreateElementNS(string @namespace, string qualifiedName);

		public extern XmlElement CreateElementNS(string @namespace, string qualifiedName, string typeExtension);

		public extern Event CreateEvent(string @interface);

		public extern XPathExpression CreateExpression(string expression, XPathNSResolver resolver);

		public extern NodeIterator CreateNodeIterator(XmlNode root);

		public extern NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow);

		public extern NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow, INodeFilter filter);

		public extern XPathNSResolver CreateNSResolver(XmlNode nodeResolver);

		public extern XmlProcessingInstruction CreateProcessingInstruction(string target, string data);

		public extern Range CreateRange();

		public extern XmlText CreateTextNode(string data);

		public extern Touch CreateTouch();

		public extern Touch CreateTouch(WindowInstance view);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, double rotationAngle);

		public extern Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, double rotationAngle, double force);

		public extern TouchList CreateTouchList();

		[ExpandParams]
		public extern TouchList CreateTouchList(Touch touch, params Touch[] touches);

		public extern TouchList CreateTouchList(Touch[] touches);

		public extern TreeWalker CreateTreeWalker(XmlNode root);

		public extern TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow);

		public extern TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow, INodeFilter filter);

		public readonly XmlElement CurrentScript;

		public readonly WindowInstance DefaultView;

		public string Dir;

		public readonly DocumentType Doctype;

		public readonly XmlElement DocumentElement;

		public readonly string DocumentURI;

		public extern XmlElement ElementFromPoint(double x, double y);

		public extern void EnableStyleSheetsForSet(string name);

		public extern XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result);

		public readonly XmlElement FirstElementChild;

		public extern DOMQuad[] GetBoxQuads();

		public extern DOMQuad[] GetBoxQuads(BoxQuadOptions options);

		public extern XmlElement GetElementById(string elementId);

		public extern XmlElementCollection GetElementsByClassName(string classNames);

		public extern XmlElementCollection GetElementsByTagName(string localName);

		public extern XmlElementCollection GetElementsByTagNameNS(string @namespace, string localName);

		public extern bool HasFocus();

		public readonly bool Hidden;

		public readonly DOMImplementation Implementation;

		public extern XmlNode ImportNode(XmlNode node);

		public extern XmlNode ImportNode(XmlNode node, bool deep);

		public readonly string InputEncoding;

		public readonly XmlElement LastElementChild;

		public readonly string LastModified;

		public readonly string LastStyleSheetSet;

		public readonly Location Location;

		[Name("onabort")]
		public HtmlEventHandler OnAbort;

		[Name("onafterscriptexecute")]
		public HtmlEventHandler OnAfterscriptexecute;

		[Name("onbeforescriptexecute")]
		public HtmlEventHandler OnBeforescriptexecute;

		[Name("onblur")]
		public HtmlEventHandler OnBlur;

		[Name("oncanplay")]
		public HtmlEventHandler OnCanplay;

		[Name("oncanplaythrough")]
		public HtmlEventHandler OnCanplaythrough;

		[Name("onchange")]
		public HtmlEventHandler OnChange;

		[Name("onclick")]
		public HtmlEventHandler OnClick;

		[Name("oncontextmenu")]
		public HtmlEventHandler OnContextmenu;

		[Name("oncopy")]
		public HtmlEventHandler OnCopy;

		[Name("oncut")]
		public HtmlEventHandler OnCut;

		[Name("ondblclick")]
		public HtmlEventHandler OnDblclick;

		[Name("ondrag")]
		public HtmlEventHandler OnDrag;

		[Name("ondragend")]
		public HtmlEventHandler OnDragend;

		[Name("ondragenter")]
		public HtmlEventHandler OnDragenter;

		[Name("ondragleave")]
		public HtmlEventHandler OnDragleave;

		[Name("ondragover")]
		public HtmlEventHandler OnDragover;

		[Name("ondragstart")]
		public HtmlEventHandler OnDragstart;

		[Name("ondrop")]
		public HtmlEventHandler OnDrop;

		[Name("ondurationchange")]
		public HtmlEventHandler OnDurationchange;

		[Name("onemptied")]
		public HtmlEventHandler OnEmptied;

		[Name("onended")]
		public HtmlEventHandler OnEnded;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onfocus")]
		public HtmlEventHandler OnFocus;

		[Name("oninput")]
		public HtmlEventHandler OnInput;

		[Name("oninvalid")]
		public HtmlEventHandler OnInvalid;

		[Name("onkeydown")]
		public HtmlEventHandler OnKeydown;

		[Name("onkeypress")]
		public HtmlEventHandler OnKeypress;

		[Name("onkeyup")]
		public HtmlEventHandler OnKeyup;

		[Name("onload")]
		public HtmlEventHandler OnLoad;

		[Name("onloadeddata")]
		public HtmlEventHandler OnLoadeddata;

		[Name("onloadedmetadata")]
		public HtmlEventHandler OnLoadedmetadata;

		[Name("onloadstart")]
		public HtmlEventHandler OnLoadstart;

		[Name("onmousedown")]
		public HtmlEventHandler OnMousedown;

		[Name("onmouseenter")]
		public HtmlEventHandler OnMouseenter;

		[Name("onmouseleave")]
		public HtmlEventHandler OnMouseleave;

		[Name("onmousemove")]
		public HtmlEventHandler OnMousemove;

		[Name("onmouseout")]
		public HtmlEventHandler OnMouseout;

		[Name("onmouseover")]
		public HtmlEventHandler OnMouseover;

		[Name("onmouseup")]
		public HtmlEventHandler OnMouseup;

		[Name("onpaste")]
		public HtmlEventHandler OnPaste;

		[Name("onpause")]
		public HtmlEventHandler OnPause;

		[Name("onplay")]
		public HtmlEventHandler OnPlay;

		[Name("onplaying")]
		public HtmlEventHandler OnPlaying;

		[Name("onpointercancel")]
		public HtmlEventHandler OnPointercancel;

		[Name("onpointerdown")]
		public HtmlEventHandler OnPointerdown;

		[Name("onpointerenter")]
		public HtmlEventHandler OnPointerenter;

		[Name("onpointerleave")]
		public HtmlEventHandler OnPointerleave;

		[Name("onpointermove")]
		public HtmlEventHandler OnPointermove;

		[Name("onpointerout")]
		public HtmlEventHandler OnPointerout;

		[Name("onpointerover")]
		public HtmlEventHandler OnPointerover;

		[Name("onpointerup")]
		public HtmlEventHandler OnPointerup;

		[Name("onprogress")]
		public HtmlEventHandler OnProgress;

		[Name("onratechange")]
		public HtmlEventHandler OnRatechange;

		[Name("onreadystatechange")]
		public HtmlEventHandler OnReadystatechange;

		[Name("onreset")]
		public HtmlEventHandler OnReset;

		[Name("onscroll")]
		public HtmlEventHandler OnScroll;

		[Name("onseeked")]
		public HtmlEventHandler OnSeeked;

		[Name("onseeking")]
		public HtmlEventHandler OnSeeking;

		[Name("onselect")]
		public HtmlEventHandler OnSelect;

		[Name("onshow")]
		public HtmlEventHandler OnShow;

		[Name("onstalled")]
		public HtmlEventHandler OnStalled;

		[Name("onsubmit")]
		public HtmlEventHandler OnSubmit;

		[Name("onsuspend")]
		public HtmlEventHandler OnSuspend;

		[Name("ontimeupdate")]
		public HtmlEventHandler OnTimeupdate;

		[Name("ontouchcancel")]
		public HtmlEventHandler OnTouchcancel;

		[Name("ontouchend")]
		public HtmlEventHandler OnTouchend;

		[Name("ontouchenter")]
		public HtmlEventHandler OnTouchenter;

		[Name("ontouchleave")]
		public HtmlEventHandler OnTouchleave;

		[Name("ontouchmove")]
		public HtmlEventHandler OnTouchmove;

		[Name("ontouchstart")]
		public HtmlEventHandler OnTouchstart;

		[Name("onvolumechange")]
		public HtmlEventHandler OnVolumechange;

		[Name("onwaiting")]
		public HtmlEventHandler OnWaiting;

		[Name("onwheel")]
		public HtmlEventHandler OnWheel;

		public readonly string PreferredStyleSheetSet;

		public extern XmlElement QuerySelector(string selectors);

		public extern XmlNodeList QuerySelectorAll(string selectors);

		public readonly string ReadyState;

		public readonly string Referrer;

		public extern object RegisterElement(string name);

		public extern object RegisterElement(string name, ElementRegistrationOptions options);

		public extern void ReleaseCapture();

		public extern void RemoveEventListener(DocumentBaseEvents type, Action listener);

		public extern void RemoveEventListener(DocumentBaseEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener);

		public extern void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture);

		public extern void RemoveEventListener(DocumentBaseEvents type, IEventListener listener);

		public extern void RemoveEventListener(DocumentBaseEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture);

		public string SelectedStyleSheetSet;

		public readonly StyleSheetList StyleSheets;

		public readonly DOMStringList StyleSheetSets;

		public string Title;

		public readonly string URL;

		public readonly VisibilityState VisibilityState;
	}
}
