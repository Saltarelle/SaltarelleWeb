using System.Html;
using System.Html.Editing;
using System.Html.WebComponents;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Document")]
	public partial class DocumentBase : XmlNode, IXPathEvaluator, IGeometryUtils {
		public DocumentBase() {
		}

		[IntrinsicProperty]
		public XmlElement ActiveElement {
			get {
				return default(XmlElement);
			}
		}

		public void AddEventListener(DocumentBaseEvents type, Action listener) {
		}

		public void AddEventListener(DocumentBaseEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener) {
		}

		public void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture) {
		}

		public void AddEventListener(DocumentBaseEvents type, IEventListener listener) {
		}

		public void AddEventListener(DocumentBaseEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture) {
		}

		public XmlNode AdoptNode(XmlNode node) {
			return default(XmlNode);
		}

		public CaretPosition CaretPositionFromPoint(float x, float y) {
			return default(CaretPosition);
		}

		[IntrinsicProperty]
		public string CharacterSet {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public uint ChildElementCount {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public XmlElementCollection Children {
			get {
				return default(XmlElementCollection);
			}
		}

		[IntrinsicProperty]
		public string CompatMode {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string ContentType {
			get {
				return null;
			}
		}

		public DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from) {
			return default(DOMPoint);
		}

		public DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options) {
			return default(DOMPoint);
		}

		public DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from) {
			return default(DOMQuad);
		}

		public DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options) {
			return default(DOMQuad);
		}

		public DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from) {
			return default(DOMQuad);
		}

		public DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options) {
			return default(DOMQuad);
		}

		public XmlAttribute CreateAttribute(string name) {
			return default(XmlAttribute);
		}

		public XmlAttribute CreateAttributeNS(string @namespace, string name) {
			return default(XmlAttribute);
		}

		public XmlCDataSection CreateCDATASection(string data) {
			return default(XmlCDataSection);
		}

		public XmlComment CreateComment(string data) {
			return default(XmlComment);
		}

		public XmlDocumentFragment CreateDocumentFragment() {
			return default(XmlDocumentFragment);
		}

		public XmlElement CreateElement(string localName) {
			return default(XmlElement);
		}

		public XmlElement CreateElement(string localName, string typeExtension) {
			return default(XmlElement);
		}

		public XmlElement CreateElementNS(string @namespace, string qualifiedName) {
			return default(XmlElement);
		}

		public XmlElement CreateElementNS(string @namespace, string qualifiedName, string typeExtension) {
			return default(XmlElement);
		}

		public Event CreateEvent(string @interface) {
			return default(Event);
		}

		public XPathExpression CreateExpression(string expression, XPathNSResolver resolver) {
			return default(XPathExpression);
		}

		public NodeIterator CreateNodeIterator(XmlNode root) {
			return default(NodeIterator);
		}

		public NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow) {
			return default(NodeIterator);
		}

		public NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow, INodeFilter filter) {
			return default(NodeIterator);
		}

		public XPathNSResolver CreateNSResolver(XmlNode nodeResolver) {
			return default(XPathNSResolver);
		}

		public XmlProcessingInstruction CreateProcessingInstruction(string target, string data) {
			return default(XmlProcessingInstruction);
		}

		public Range CreateRange() {
			return default(Range);
		}

		public XmlText CreateTextNode(string data) {
			return default(XmlText);
		}

		public Touch CreateTouch() {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, float rotationAngle) {
			return default(Touch);
		}

		public Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, float rotationAngle, float force) {
			return default(Touch);
		}

		public TouchList CreateTouchList() {
			return default(TouchList);
		}

		[ExpandParams]
		public TouchList CreateTouchList(Touch touch, params Touch[] touches) {
			return default(TouchList);
		}

		public TouchList CreateTouchList(Touch[] touches) {
			return default(TouchList);
		}

		public TreeWalker CreateTreeWalker(XmlNode root) {
			return default(TreeWalker);
		}

		public TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow) {
			return default(TreeWalker);
		}

		public TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow, INodeFilter filter) {
			return default(TreeWalker);
		}

		[IntrinsicProperty]
		public XmlElement CurrentScript {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public WindowInstance DefaultView {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public string Dir {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public DocumentType Doctype {
			get {
				return default(DocumentType);
			}
		}

		[IntrinsicProperty]
		public XmlElement DocumentElement {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public string DocumentURI {
			get {
				return null;
			}
		}

		public XmlElement ElementFromPoint(float x, float y) {
			return default(XmlElement);
		}

		public void EnableStyleSheetsForSet(string name) {
		}

		public XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result) {
			return default(XPathResult);
		}

		[IntrinsicProperty]
		public XmlElement FirstElementChild {
			get {
				return default(XmlElement);
			}
		}

		public DOMQuad[] GetBoxQuads() {
			return null;
		}

		public DOMQuad[] GetBoxQuads(BoxQuadOptions options) {
			return null;
		}

		public XmlElement GetElementById(string elementId) {
			return default(XmlElement);
		}

		public XmlElementCollection GetElementsByClassName(string classNames) {
			return default(XmlElementCollection);
		}

		public XmlElementCollection GetElementsByTagName(string localName) {
			return default(XmlElementCollection);
		}

		public XmlElementCollection GetElementsByTagNameNS(string @namespace, string localName) {
			return default(XmlElementCollection);
		}

		public bool HasFocus() {
			return false;
		}

		[IntrinsicProperty]
		public bool Hidden {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public DOMImplementation Implementation {
			get {
				return default(DOMImplementation);
			}
		}

		public XmlNode ImportNode(XmlNode node) {
			return default(XmlNode);
		}

		public XmlNode ImportNode(XmlNode node, bool deep) {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public string InputEncoding {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public XmlElement LastElementChild {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public string LastModified {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string LastStyleSheetSet {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public Location Location {
			get {
				return default(Location);
			}
		}

		[IntrinsicProperty, ScriptName("onabort")]
		public HtmlEventHandler OnAbort {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onafterscriptexecute")]
		public HtmlEventHandler OnAfterscriptexecute {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onbeforescriptexecute")]
		public HtmlEventHandler OnBeforescriptexecute {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onblur")]
		public HtmlEventHandler OnBlur {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncanplay")]
		public HtmlEventHandler OnCanplay {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncanplaythrough")]
		public HtmlEventHandler OnCanplaythrough {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onchange")]
		public HtmlEventHandler OnChange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onclick")]
		public HtmlEventHandler OnClick {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncontextmenu")]
		public HtmlEventHandler OnContextmenu {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncopy")]
		public HtmlEventHandler OnCopy {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncut")]
		public HtmlEventHandler OnCut {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondblclick")]
		public HtmlEventHandler OnDblclick {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondrag")]
		public HtmlEventHandler OnDrag {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragend")]
		public HtmlEventHandler OnDragend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragenter")]
		public HtmlEventHandler OnDragenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragleave")]
		public HtmlEventHandler OnDragleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragover")]
		public HtmlEventHandler OnDragover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragstart")]
		public HtmlEventHandler OnDragstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondrop")]
		public HtmlEventHandler OnDrop {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondurationchange")]
		public HtmlEventHandler OnDurationchange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onemptied")]
		public HtmlEventHandler OnEmptied {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onended")]
		public HtmlEventHandler OnEnded {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onfocus")]
		public HtmlEventHandler OnFocus {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oninput")]
		public HtmlEventHandler OnInput {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oninvalid")]
		public HtmlEventHandler OnInvalid {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeydown")]
		public HtmlEventHandler OnKeydown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeypress")]
		public HtmlEventHandler OnKeypress {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeyup")]
		public HtmlEventHandler OnKeyup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onload")]
		public HtmlEventHandler OnLoad {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadeddata")]
		public HtmlEventHandler OnLoadeddata {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadedmetadata")]
		public HtmlEventHandler OnLoadedmetadata {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadstart")]
		public HtmlEventHandler OnLoadstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmousedown")]
		public HtmlEventHandler OnMousedown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseenter")]
		public HtmlEventHandler OnMouseenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseleave")]
		public HtmlEventHandler OnMouseleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmousemove")]
		public HtmlEventHandler OnMousemove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseout")]
		public HtmlEventHandler OnMouseout {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseover")]
		public HtmlEventHandler OnMouseover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseup")]
		public HtmlEventHandler OnMouseup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpaste")]
		public HtmlEventHandler OnPaste {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpause")]
		public HtmlEventHandler OnPause {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onplay")]
		public HtmlEventHandler OnPlay {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onplaying")]
		public HtmlEventHandler OnPlaying {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointercancel")]
		public HtmlEventHandler OnPointercancel {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerdown")]
		public HtmlEventHandler OnPointerdown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerenter")]
		public HtmlEventHandler OnPointerenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerleave")]
		public HtmlEventHandler OnPointerleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointermove")]
		public HtmlEventHandler OnPointermove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerout")]
		public HtmlEventHandler OnPointerout {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerover")]
		public HtmlEventHandler OnPointerover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerup")]
		public HtmlEventHandler OnPointerup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onprogress")]
		public HtmlEventHandler OnProgress {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onratechange")]
		public HtmlEventHandler OnRatechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onreadystatechange")]
		public HtmlEventHandler OnReadystatechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onreset")]
		public HtmlEventHandler OnReset {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onscroll")]
		public HtmlEventHandler OnScroll {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onseeked")]
		public HtmlEventHandler OnSeeked {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onseeking")]
		public HtmlEventHandler OnSeeking {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onselect")]
		public HtmlEventHandler OnSelect {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onshow")]
		public HtmlEventHandler OnShow {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onstalled")]
		public HtmlEventHandler OnStalled {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsubmit")]
		public HtmlEventHandler OnSubmit {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsuspend")]
		public HtmlEventHandler OnSuspend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontimeupdate")]
		public HtmlEventHandler OnTimeupdate {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchcancel")]
		public HtmlEventHandler OnTouchcancel {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchend")]
		public HtmlEventHandler OnTouchend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchenter")]
		public HtmlEventHandler OnTouchenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchleave")]
		public HtmlEventHandler OnTouchleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchmove")]
		public HtmlEventHandler OnTouchmove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchstart")]
		public HtmlEventHandler OnTouchstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onvolumechange")]
		public HtmlEventHandler OnVolumechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onwaiting")]
		public HtmlEventHandler OnWaiting {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onwheel")]
		public HtmlEventHandler OnWheel {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string PreferredStyleSheetSet {
			get {
				return null;
			}
		}

		public XmlElement QuerySelector(string selectors) {
			return default(XmlElement);
		}

		public XmlNodeList QuerySelectorAll(string selectors) {
			return default(XmlNodeList);
		}

		[IntrinsicProperty]
		public string ReadyState {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Referrer {
			get {
				return null;
			}
		}

		public object RegisterElement(string name) {
			return null;
		}

		public object RegisterElement(string name, ElementRegistrationOptions options) {
			return null;
		}

		public void ReleaseCapture() {
		}

		public void RemoveEventListener(DocumentBaseEvents type, Action listener) {
		}

		public void RemoveEventListener(DocumentBaseEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener) {
		}

		public void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture) {
		}

		public void RemoveEventListener(DocumentBaseEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(DocumentBaseEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string SelectedStyleSheetSet {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public StyleSheetList StyleSheets {
			get {
				return default(StyleSheetList);
			}
		}

		[IntrinsicProperty]
		public DOMStringList StyleSheetSets {
			get {
				return default(DOMStringList);
			}
		}

		[IntrinsicProperty]
		public string Title {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string URL {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public VisibilityState VisibilityState {
			get {
				return default(VisibilityState);
			}
		}
	}
}
