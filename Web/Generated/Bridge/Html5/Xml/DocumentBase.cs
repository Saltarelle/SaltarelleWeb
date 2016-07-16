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

		[FieldProperty]
		public extern XmlElement ActiveElement
		{
			get;
		}

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

		[FieldProperty]
		public extern string CharacterSet
		{
			get;
		}

		[FieldProperty]
		public extern int ChildElementCount
		{
			get;
		}

		[FieldProperty]
		public extern XmlElementCollection Children
		{
			get;
		}

		[FieldProperty]
		public extern string CompatMode
		{
			get;
		}

		[FieldProperty]
		public extern string ContentType
		{
			get;
		}

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

		[FieldProperty]
		public extern XmlElement CurrentScript
		{
			get;
		}

		[FieldProperty]
		public extern WindowInstance DefaultView
		{
			get;
		}

		[FieldProperty]
		public extern string Dir
		{
			get;
			set;
		}

		[FieldProperty]
		public extern DocumentType Doctype
		{
			get;
		}

		[FieldProperty]
		public extern XmlElement DocumentElement
		{
			get;
		}

		[FieldProperty]
		public extern string DocumentURI
		{
			get;
		}

		public extern XmlElement ElementFromPoint(double x, double y);

		public extern void EnableStyleSheetsForSet(string name);

		public extern XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result);

		[FieldProperty]
		public extern XmlElement FirstElementChild
		{
			get;
		}

		public extern DOMQuad[] GetBoxQuads();

		public extern DOMQuad[] GetBoxQuads(BoxQuadOptions options);

		public extern XmlElement GetElementById(string elementId);

		public extern XmlElementCollection GetElementsByClassName(string classNames);

		public extern XmlElementCollection GetElementsByTagName(string localName);

		public extern XmlElementCollection GetElementsByTagNameNS(string @namespace, string localName);

		public extern bool HasFocus();

		[FieldProperty]
		public extern bool Hidden
		{
			get;
		}

		[FieldProperty]
		public extern DOMImplementation Implementation
		{
			get;
		}

		public extern XmlNode ImportNode(XmlNode node);

		public extern XmlNode ImportNode(XmlNode node, bool deep);

		[FieldProperty]
		public extern string InputEncoding
		{
			get;
		}

		[FieldProperty]
		public extern XmlElement LastElementChild
		{
			get;
		}

		[FieldProperty]
		public extern string LastModified
		{
			get;
		}

		[FieldProperty]
		public extern string LastStyleSheetSet
		{
			get;
		}

		[FieldProperty]
		public extern Location Location
		{
			get;
		}

		[FieldProperty, Name("onabort")]
		public extern HtmlEventHandler OnAbort
		{
			get;
			set;
		}

		[FieldProperty, Name("onafterscriptexecute")]
		public extern HtmlEventHandler OnAfterscriptexecute
		{
			get;
			set;
		}

		[FieldProperty, Name("onbeforescriptexecute")]
		public extern HtmlEventHandler OnBeforescriptexecute
		{
			get;
			set;
		}

		[FieldProperty, Name("onblur")]
		public extern HtmlEventHandler OnBlur
		{
			get;
			set;
		}

		[FieldProperty, Name("oncanplay")]
		public extern HtmlEventHandler OnCanplay
		{
			get;
			set;
		}

		[FieldProperty, Name("oncanplaythrough")]
		public extern HtmlEventHandler OnCanplaythrough
		{
			get;
			set;
		}

		[FieldProperty, Name("onchange")]
		public extern HtmlEventHandler OnChange
		{
			get;
			set;
		}

		[FieldProperty, Name("onclick")]
		public extern HtmlEventHandler OnClick
		{
			get;
			set;
		}

		[FieldProperty, Name("oncontextmenu")]
		public extern HtmlEventHandler OnContextmenu
		{
			get;
			set;
		}

		[FieldProperty, Name("oncopy")]
		public extern HtmlEventHandler OnCopy
		{
			get;
			set;
		}

		[FieldProperty, Name("oncut")]
		public extern HtmlEventHandler OnCut
		{
			get;
			set;
		}

		[FieldProperty, Name("ondblclick")]
		public extern HtmlEventHandler OnDblclick
		{
			get;
			set;
		}

		[FieldProperty, Name("ondrag")]
		public extern HtmlEventHandler OnDrag
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragend")]
		public extern HtmlEventHandler OnDragend
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragenter")]
		public extern HtmlEventHandler OnDragenter
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragleave")]
		public extern HtmlEventHandler OnDragleave
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragover")]
		public extern HtmlEventHandler OnDragover
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragstart")]
		public extern HtmlEventHandler OnDragstart
		{
			get;
			set;
		}

		[FieldProperty, Name("ondrop")]
		public extern HtmlEventHandler OnDrop
		{
			get;
			set;
		}

		[FieldProperty, Name("ondurationchange")]
		public extern HtmlEventHandler OnDurationchange
		{
			get;
			set;
		}

		[FieldProperty, Name("onemptied")]
		public extern HtmlEventHandler OnEmptied
		{
			get;
			set;
		}

		[FieldProperty, Name("onended")]
		public extern HtmlEventHandler OnEnded
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public extern HtmlEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onfocus")]
		public extern HtmlEventHandler OnFocus
		{
			get;
			set;
		}

		[FieldProperty, Name("oninput")]
		public extern HtmlEventHandler OnInput
		{
			get;
			set;
		}

		[FieldProperty, Name("oninvalid")]
		public extern HtmlEventHandler OnInvalid
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeydown")]
		public extern HtmlEventHandler OnKeydown
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeypress")]
		public extern HtmlEventHandler OnKeypress
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeyup")]
		public extern HtmlEventHandler OnKeyup
		{
			get;
			set;
		}

		[FieldProperty, Name("onload")]
		public extern HtmlEventHandler OnLoad
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadeddata")]
		public extern HtmlEventHandler OnLoadeddata
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadedmetadata")]
		public extern HtmlEventHandler OnLoadedmetadata
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadstart")]
		public extern HtmlEventHandler OnLoadstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onmousedown")]
		public extern HtmlEventHandler OnMousedown
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseenter")]
		public extern HtmlEventHandler OnMouseenter
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseleave")]
		public extern HtmlEventHandler OnMouseleave
		{
			get;
			set;
		}

		[FieldProperty, Name("onmousemove")]
		public extern HtmlEventHandler OnMousemove
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseout")]
		public extern HtmlEventHandler OnMouseout
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseover")]
		public extern HtmlEventHandler OnMouseover
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseup")]
		public extern HtmlEventHandler OnMouseup
		{
			get;
			set;
		}

		[FieldProperty, Name("onpaste")]
		public extern HtmlEventHandler OnPaste
		{
			get;
			set;
		}

		[FieldProperty, Name("onpause")]
		public extern HtmlEventHandler OnPause
		{
			get;
			set;
		}

		[FieldProperty, Name("onplay")]
		public extern HtmlEventHandler OnPlay
		{
			get;
			set;
		}

		[FieldProperty, Name("onplaying")]
		public extern HtmlEventHandler OnPlaying
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointercancel")]
		public extern HtmlEventHandler OnPointercancel
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerdown")]
		public extern HtmlEventHandler OnPointerdown
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerenter")]
		public extern HtmlEventHandler OnPointerenter
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerleave")]
		public extern HtmlEventHandler OnPointerleave
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointermove")]
		public extern HtmlEventHandler OnPointermove
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerout")]
		public extern HtmlEventHandler OnPointerout
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerover")]
		public extern HtmlEventHandler OnPointerover
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerup")]
		public extern HtmlEventHandler OnPointerup
		{
			get;
			set;
		}

		[FieldProperty, Name("onprogress")]
		public extern HtmlEventHandler OnProgress
		{
			get;
			set;
		}

		[FieldProperty, Name("onratechange")]
		public extern HtmlEventHandler OnRatechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onreadystatechange")]
		public extern HtmlEventHandler OnReadystatechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onreset")]
		public extern HtmlEventHandler OnReset
		{
			get;
			set;
		}

		[FieldProperty, Name("onscroll")]
		public extern HtmlEventHandler OnScroll
		{
			get;
			set;
		}

		[FieldProperty, Name("onseeked")]
		public extern HtmlEventHandler OnSeeked
		{
			get;
			set;
		}

		[FieldProperty, Name("onseeking")]
		public extern HtmlEventHandler OnSeeking
		{
			get;
			set;
		}

		[FieldProperty, Name("onselect")]
		public extern HtmlEventHandler OnSelect
		{
			get;
			set;
		}

		[FieldProperty, Name("onshow")]
		public extern HtmlEventHandler OnShow
		{
			get;
			set;
		}

		[FieldProperty, Name("onstalled")]
		public extern HtmlEventHandler OnStalled
		{
			get;
			set;
		}

		[FieldProperty, Name("onsubmit")]
		public extern HtmlEventHandler OnSubmit
		{
			get;
			set;
		}

		[FieldProperty, Name("onsuspend")]
		public extern HtmlEventHandler OnSuspend
		{
			get;
			set;
		}

		[FieldProperty, Name("ontimeupdate")]
		public extern HtmlEventHandler OnTimeupdate
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchcancel")]
		public extern HtmlEventHandler OnTouchcancel
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchend")]
		public extern HtmlEventHandler OnTouchend
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchenter")]
		public extern HtmlEventHandler OnTouchenter
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchleave")]
		public extern HtmlEventHandler OnTouchleave
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchmove")]
		public extern HtmlEventHandler OnTouchmove
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchstart")]
		public extern HtmlEventHandler OnTouchstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onvolumechange")]
		public extern HtmlEventHandler OnVolumechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onwaiting")]
		public extern HtmlEventHandler OnWaiting
		{
			get;
			set;
		}

		[FieldProperty, Name("onwheel")]
		public extern HtmlEventHandler OnWheel
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string PreferredStyleSheetSet
		{
			get;
		}

		public extern XmlElement QuerySelector(string selectors);

		public extern XmlNodeList QuerySelectorAll(string selectors);

		[FieldProperty]
		public extern string ReadyState
		{
			get;
		}

		[FieldProperty]
		public extern string Referrer
		{
			get;
		}

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

		[FieldProperty]
		public extern string SelectedStyleSheetSet
		{
			get;
			set;
		}

		[FieldProperty]
		public extern StyleSheetList StyleSheets
		{
			get;
		}

		[FieldProperty]
		public extern DOMStringList StyleSheetSets
		{
			get;
		}

		[FieldProperty]
		public extern string Title
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string URL
		{
			get;
		}

		[FieldProperty]
		public extern VisibilityState VisibilityState
		{
			get;
		}
	}
}
