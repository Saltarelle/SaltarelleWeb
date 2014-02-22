using System.Html.Editing;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.XPath;

namespace System.Html {
	[IgnoreNamespace, Imported, ScriptName("document")]
	public static partial class Document {
		public static void AddEventListener(DocumentBaseEvents type, Action listener) {
		}

		public static void AddEventListener(DocumentBaseEvents type, Action listener, bool capture) {
		}

		public static void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener) {
		}

		public static void AddEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture) {
		}

		public static void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener) {
		}

		public static void AddEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture) {
		}

		public static void AddEventListener(DocumentBaseEvents type, IEventListener listener) {
		}

		public static void AddEventListener(DocumentBaseEvents type, IEventListener listener, bool capture) {
		}

		public static void AddEventListener(DocumentInstanceEvents type, Action listener) {
		}

		public static void AddEventListener(DocumentInstanceEvents type, Action listener, bool capture) {
		}

		public static void AddEventListener(DocumentInstanceEvents type, HtmlEventHandler listener) {
		}

		public static void AddEventListener(DocumentInstanceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public static void AddEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener) {
		}

		public static void AddEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture) {
		}

		public static void AddEventListener(DocumentInstanceEvents type, IEventListener listener) {
		}

		public static void AddEventListener(DocumentInstanceEvents type, IEventListener listener, bool capture) {
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener) {
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener) {
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener) {
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture) {
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture) {
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture) {
		}

		public static void AddEventListener(string type, IEventListener listener) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted) {
		}

		public static void AddEventListener(XmlNodeEvents type, Action listener) {
		}

		public static void AddEventListener(XmlNodeEvents type, Action listener, bool capture) {
		}

		public static void AddEventListener(XmlNodeEvents type, HtmlEventHandler listener) {
		}

		public static void AddEventListener(XmlNodeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public static void AddEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener) {
		}

		public static void AddEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture) {
		}

		public static void AddEventListener(XmlNodeEvents type, IEventListener listener) {
		}

		public static void AddEventListener(XmlNodeEvents type, IEventListener listener, bool capture) {
		}

		public static XmlNode AdoptNode(XmlNode node) {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public static string AlinkColor {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static object All {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static ElementCollection Anchors {
			get {
				return default(ElementCollection);
			}
		}

		public static XmlNode AppendChild(XmlNode node) {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public static ElementCollection Applets {
			get {
				return default(ElementCollection);
			}
		}

		[ScriptName("ATTRIBUTE_NODE")]
		public const ushort ATTRIBUTE_NODE = 2;

		[IntrinsicProperty]
		public static string BaseURI {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string BgColor {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static Element Body {
			get {
				return default(Element);
			}
			set {
			}
		}

		public static void CaptureEvents(int eventFlags) {
		}

		public static CaretPosition CaretPositionFromPoint(float x, float y) {
			return default(CaretPosition);
		}

		[ScriptName("CDATA_SECTION_NODE")]
		public const ushort CDATA_SECTION_NODE = 4;

		[IntrinsicProperty]
		public static string CharacterSet {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static uint ChildElementCount {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public static XmlNodeList ChildNodes {
			get {
				return default(XmlNodeList);
			}
		}

		[IntrinsicProperty]
		public static ElementCollection Children {
			get {
				return default(ElementCollection);
			}
		}

		public static void Clear() {
		}

		public static XmlNode CloneNode() {
			return default(XmlNode);
		}

		public static XmlNode CloneNode(bool deep) {
			return default(XmlNode);
		}

		public static void Close() {
		}

		[ScriptName("COMMENT_NODE")]
		public const ushort COMMENT_NODE = 8;

		public static DocumentPosition CompareDocumentPosition(XmlNode other) {
			return default(DocumentPosition);
		}

		[IntrinsicProperty]
		public static string CompatMode {
			get {
				return null;
			}
		}

		public static bool Contains(XmlNode other) {
			return false;
		}

		[IntrinsicProperty]
		public static string ContentType {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string Cookie {
			get {
				return null;
			}
			set {
			}
		}

		public static XmlAttribute CreateAttribute(string name) {
			return default(XmlAttribute);
		}

		public static XmlAttribute CreateAttributeNS(string @namespace, string name) {
			return default(XmlAttribute);
		}

		public static XmlCDataSection CreateCDATASection(string data) {
			return default(XmlCDataSection);
		}

		public static XmlComment CreateComment(string data) {
			return default(XmlComment);
		}

		public static XmlDocumentFragment CreateDocumentFragment() {
			return default(XmlDocumentFragment);
		}

		public static Event CreateEvent(string @interface) {
			return default(Event);
		}

		public static XPathExpression CreateExpression(string expression, XPathNSResolver resolver) {
			return default(XPathExpression);
		}

		public static NodeIterator CreateNodeIterator(XmlNode root) {
			return default(NodeIterator);
		}

		public static NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow) {
			return default(NodeIterator);
		}

		public static NodeIterator CreateNodeIterator(XmlNode root, NodeFilter whatToShow, INodeFilter filter) {
			return default(NodeIterator);
		}

		public static XPathNSResolver CreateNSResolver(XmlNode nodeResolver) {
			return default(XPathNSResolver);
		}

		public static XmlProcessingInstruction CreateProcessingInstruction(string target, string data) {
			return default(XmlProcessingInstruction);
		}

		public static Range CreateRange() {
			return default(Range);
		}

		public static XmlText CreateTextNode(string data) {
			return default(XmlText);
		}

		public static Touch CreateTouch() {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, float rotationAngle) {
			return default(Touch);
		}

		public static Touch CreateTouch(WindowInstance view, EventTarget target, int identifier, int pageX, int pageY, int screenX, int screenY, int clientX, int clientY, int radiusX, int radiusY, float rotationAngle, float force) {
			return default(Touch);
		}

		public static TouchList CreateTouchList() {
			return default(TouchList);
		}

		[ExpandParams]
		public static TouchList CreateTouchList(Touch touch, params Touch[] touches) {
			return default(TouchList);
		}

		public static TouchList CreateTouchList(Touch[] touches) {
			return default(TouchList);
		}

		public static TreeWalker CreateTreeWalker(XmlNode root) {
			return default(TreeWalker);
		}

		public static TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow) {
			return default(TreeWalker);
		}

		public static TreeWalker CreateTreeWalker(XmlNode root, NodeFilter whatToShow, INodeFilter filter) {
			return default(TreeWalker);
		}

		[IntrinsicProperty]
		public static WindowInstance DefaultView {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public static string DesignMode {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static string Dir {
			get {
				return null;
			}
			set {
			}
		}

		public static bool DispatchEvent(Event @event) {
			return false;
		}

		[IntrinsicProperty]
		public static DocumentType Doctype {
			get {
				return default(DocumentType);
			}
		}

		[ScriptName("DOCUMENT_FRAGMENT_NODE")]
		public const ushort DOCUMENT_FRAGMENT_NODE = 11;

		[ScriptName("DOCUMENT_NODE")]
		public const ushort DOCUMENT_NODE = 9;

		[ScriptName("DOCUMENT_POSITION_CONTAINED_BY")]
		public const ushort DOCUMENT_POSITION_CONTAINED_BY = 16;

		[ScriptName("DOCUMENT_POSITION_CONTAINS")]
		public const ushort DOCUMENT_POSITION_CONTAINS = 8;

		[ScriptName("DOCUMENT_POSITION_DISCONNECTED")]
		public const ushort DOCUMENT_POSITION_DISCONNECTED = 1;

		[ScriptName("DOCUMENT_POSITION_FOLLOWING")]
		public const ushort DOCUMENT_POSITION_FOLLOWING = 4;

		[ScriptName("DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC")]
		public const ushort DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 32;

		[ScriptName("DOCUMENT_POSITION_PRECEDING")]
		public const ushort DOCUMENT_POSITION_PRECEDING = 2;

		[ScriptName("DOCUMENT_TYPE_NODE")]
		public const ushort DOCUMENT_TYPE_NODE = 10;

		[IntrinsicProperty]
		public static string DocumentURI {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string Domain {
			get {
				return null;
			}
			set {
			}
		}

		[ScriptName("ELEMENT_NODE")]
		public const ushort ELEMENT_NODE = 1;

		[IntrinsicProperty]
		public static ElementCollection Embeds {
			get {
				return default(ElementCollection);
			}
		}

		public static void EnableStyleSheetsForSet(string name) {
		}

		[ScriptName("ENTITY_NODE")]
		public const ushort ENTITY_NODE = 6;

		[ScriptName("ENTITY_REFERENCE_NODE")]
		public const ushort ENTITY_REFERENCE_NODE = 5;

		public static XPathResult Evaluate(string expression, XmlNode contextNode, XPathNSResolver resolver, ushort type, XPathResult result) {
			return default(XPathResult);
		}

		public static bool ExecCommand(string commandId) {
			return false;
		}

		public static bool ExecCommand(string commandId, bool showUI) {
			return false;
		}

		public static bool ExecCommand(string commandId, bool showUI, string value) {
			return false;
		}

		[IntrinsicProperty]
		public static string FgColor {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static XmlNode FirstChild {
			get {
				return default(XmlNode);
			}
		}

		[IntrinsicProperty]
		public static ElementCollection Forms {
			get {
				return default(ElementCollection);
			}
		}

		public static XmlNodeList GetAnonymousNodes(XmlElement elt) {
			return default(XmlNodeList);
		}

		public static ElementCollection GetElementsByClassName(string classNames) {
			return default(ElementCollection);
		}

		public static XmlNodeList GetElementsByName(string elementName) {
			return default(XmlNodeList);
		}

		public static ElementCollection GetElementsByTagName(string localName) {
			return default(ElementCollection);
		}

		public static ElementCollection GetElementsByTagNameNS(string @namespace, string localName) {
			return default(ElementCollection);
		}

		public static XmlNodeList GetItems() {
			return default(XmlNodeList);
		}

		public static XmlNodeList GetItems(string typeNames) {
			return default(XmlNodeList);
		}

		public static Selection GetSelection() {
			return default(Selection);
		}

		public static object GetUserData(string key) {
			return null;
		}

		public static bool HasAttributes() {
			return false;
		}

		public static bool HasChildNodes() {
			return false;
		}

		public static bool HasFocus() {
			return false;
		}

		[IntrinsicProperty]
		public static HeadElement Head {
			get {
				return default(HeadElement);
			}
		}

		[IntrinsicProperty]
		public static bool Hidden {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public static ElementCollection Images {
			get {
				return default(ElementCollection);
			}
		}

		[IntrinsicProperty]
		public static DOMImplementation Implementation {
			get {
				return default(DOMImplementation);
			}
		}

		public static XmlNode ImportNode(XmlNode node) {
			return default(XmlNode);
		}

		public static XmlNode ImportNode(XmlNode node, bool deep) {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public static string InputEncoding {
			get {
				return null;
			}
		}

		public static XmlNode InsertBefore(XmlNode node, XmlNode child) {
			return default(XmlNode);
		}

		public static bool IsDefaultNamespace(string @namespace) {
			return false;
		}

		public static bool IsEqualNode(XmlNode node) {
			return false;
		}

		[IntrinsicProperty]
		public static XmlNode LastChild {
			get {
				return default(XmlNode);
			}
		}

		[IntrinsicProperty]
		public static string LastModified {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string LastStyleSheetSet {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string LinkColor {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static ElementCollection Links {
			get {
				return default(ElementCollection);
			}
		}

		public static void LoadBindingDocument(string documentURL) {
		}

		[IntrinsicProperty]
		public static string LocalName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static Location Location {
			get {
				return default(Location);
			}
		}

		public static string LookupNamespaceURI(string prefix) {
			return null;
		}

		public static string LookupPrefix(string @namespace) {
			return null;
		}

		[IntrinsicProperty]
		public static string NamespaceURI {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static XmlNode NextSibling {
			get {
				return default(XmlNode);
			}
		}

		[IntrinsicProperty]
		public static string NodeName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static XmlNodeType NodeType {
			get {
				return default(XmlNodeType);
			}
		}

		[IntrinsicProperty]
		public static string NodeValue {
			get {
				return null;
			}
			set {
			}
		}

		public static void Normalize() {
		}

		[ScriptName("NOTATION_NODE")]
		public const ushort NOTATION_NODE = 12;

		[IntrinsicProperty, ScriptName("onabort")]
		public static HtmlEventHandler OnAbort {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onafterscriptexecute")]
		public static HtmlEventHandler OnAfterscriptexecute {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onbeforescriptexecute")]
		public static HtmlEventHandler OnBeforescriptexecute {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onblur")]
		public static HtmlEventHandler OnBlur {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncanplay")]
		public static HtmlEventHandler OnCanplay {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncanplaythrough")]
		public static HtmlEventHandler OnCanplaythrough {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onchange")]
		public static HtmlEventHandler OnChange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onclick")]
		public static HtmlEventHandler OnClick {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncontextmenu")]
		public static HtmlEventHandler OnContextmenu {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncopy")]
		public static HtmlEventHandler OnCopy {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncut")]
		public static HtmlEventHandler OnCut {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondblclick")]
		public static HtmlEventHandler OnDblclick {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondrag")]
		public static HtmlEventHandler OnDrag {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragend")]
		public static HtmlEventHandler OnDragend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragenter")]
		public static HtmlEventHandler OnDragenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragleave")]
		public static HtmlEventHandler OnDragleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragover")]
		public static HtmlEventHandler OnDragover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragstart")]
		public static HtmlEventHandler OnDragstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondrop")]
		public static HtmlEventHandler OnDrop {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondurationchange")]
		public static HtmlEventHandler OnDurationchange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onemptied")]
		public static HtmlEventHandler OnEmptied {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onended")]
		public static HtmlEventHandler OnEnded {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public static HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onfocus")]
		public static HtmlEventHandler OnFocus {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oninput")]
		public static HtmlEventHandler OnInput {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oninvalid")]
		public static HtmlEventHandler OnInvalid {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeydown")]
		public static HtmlEventHandler OnKeydown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeypress")]
		public static HtmlEventHandler OnKeypress {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeyup")]
		public static HtmlEventHandler OnKeyup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onload")]
		public static HtmlEventHandler OnLoad {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadeddata")]
		public static HtmlEventHandler OnLoadeddata {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadedmetadata")]
		public static HtmlEventHandler OnLoadedmetadata {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadstart")]
		public static HtmlEventHandler OnLoadstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmousedown")]
		public static HtmlEventHandler OnMousedown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseenter")]
		public static HtmlEventHandler OnMouseenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseleave")]
		public static HtmlEventHandler OnMouseleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmousemove")]
		public static HtmlEventHandler OnMousemove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseout")]
		public static HtmlEventHandler OnMouseout {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseover")]
		public static HtmlEventHandler OnMouseover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseup")]
		public static HtmlEventHandler OnMouseup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpaste")]
		public static HtmlEventHandler OnPaste {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpause")]
		public static HtmlEventHandler OnPause {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onplay")]
		public static HtmlEventHandler OnPlay {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onplaying")]
		public static HtmlEventHandler OnPlaying {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerdown")]
		public static HtmlEventHandler OnPointerdown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerenter")]
		public static HtmlEventHandler OnPointerenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerleave")]
		public static HtmlEventHandler OnPointerleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointermove")]
		public static HtmlEventHandler OnPointermove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerout")]
		public static HtmlEventHandler OnPointerout {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerover")]
		public static HtmlEventHandler OnPointerover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerup")]
		public static HtmlEventHandler OnPointerup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onprogress")]
		public static HtmlEventHandler OnProgress {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onratechange")]
		public static HtmlEventHandler OnRatechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onreadystatechange")]
		public static HtmlEventHandler OnReadystatechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onreset")]
		public static HtmlEventHandler OnReset {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onscroll")]
		public static HtmlEventHandler OnScroll {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onseeked")]
		public static HtmlEventHandler OnSeeked {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onseeking")]
		public static HtmlEventHandler OnSeeking {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onselect")]
		public static HtmlEventHandler OnSelect {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onshow")]
		public static HtmlEventHandler OnShow {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onstalled")]
		public static HtmlEventHandler OnStalled {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsubmit")]
		public static HtmlEventHandler OnSubmit {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsuspend")]
		public static HtmlEventHandler OnSuspend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontimeupdate")]
		public static HtmlEventHandler OnTimeupdate {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchcancel")]
		public static HtmlEventHandler OnTouchcancel {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchend")]
		public static HtmlEventHandler OnTouchend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchenter")]
		public static HtmlEventHandler OnTouchenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchleave")]
		public static HtmlEventHandler OnTouchleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchmove")]
		public static HtmlEventHandler OnTouchmove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchstart")]
		public static HtmlEventHandler OnTouchstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onvolumechange")]
		public static HtmlEventHandler OnVolumechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onwaiting")]
		public static HtmlEventHandler OnWaiting {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onwheel")]
		public static HtmlEventHandler OnWheel {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public static DocumentBase Open() {
			return default(DocumentBase);
		}

		public static DocumentBase Open(string type) {
			return default(DocumentBase);
		}

		public static DocumentBase Open(string type, string replace) {
			return default(DocumentBase);
		}

		public static WindowInstance Open(string url, string name, string features) {
			return default(WindowInstance);
		}

		public static WindowInstance Open(string url, string name, string features, bool replace) {
			return default(WindowInstance);
		}

		[IntrinsicProperty]
		public static DocumentBase OwnerDocument {
			get {
				return default(DocumentBase);
			}
		}

		[IntrinsicProperty]
		public static XmlNode ParentNode {
			get {
				return default(XmlNode);
			}
		}

		[IntrinsicProperty]
		public static ElementCollection Plugins {
			get {
				return default(ElementCollection);
			}
		}

		[IntrinsicProperty]
		public static string PreferredStyleSheetSet {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string Prefix {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static XmlNode PreviousSibling {
			get {
				return default(XmlNode);
			}
		}

		[ScriptName("PROCESSING_INSTRUCTION_NODE")]
		public const ushort PROCESSING_INSTRUCTION_NODE = 7;

		public static bool QueryCommandEnabled(string commandId) {
			return false;
		}

		public static bool QueryCommandIndeterm(string commandId) {
			return false;
		}

		public static bool QueryCommandState(string commandId) {
			return false;
		}

		public static bool QueryCommandSupported(string commandId) {
			return false;
		}

		public static string QueryCommandValue(string commandId) {
			return null;
		}

		public static XmlNodeList QuerySelectorAll(string selectors) {
			return default(XmlNodeList);
		}

		[IntrinsicProperty]
		public static string ReadyState {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static string Referrer {
			get {
				return null;
			}
		}

		public static void ReleaseCapture() {
		}

		public static void ReleaseEvents(int eventFlags) {
		}

		public static XmlNode RemoveChild(XmlNode child) {
			return default(XmlNode);
		}

		public static void RemoveEventListener(DocumentBaseEvents type, Action listener) {
		}

		public static void RemoveEventListener(DocumentBaseEvents type, Action listener, bool capture) {
		}

		public static void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener) {
		}

		public static void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandler listener, bool capture) {
		}

		public static void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener) {
		}

		public static void RemoveEventListener(DocumentBaseEvents type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture) {
		}

		public static void RemoveEventListener(DocumentBaseEvents type, IEventListener listener) {
		}

		public static void RemoveEventListener(DocumentBaseEvents type, IEventListener listener, bool capture) {
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, Action listener) {
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, Action listener, bool capture) {
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandler listener) {
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener) {
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture) {
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, IEventListener listener) {
		}

		public static void RemoveEventListener(DocumentInstanceEvents type, IEventListener listener, bool capture) {
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener) {
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener) {
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener) {
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture) {
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentBase> listener, bool capture) {
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture) {
		}

		public static void RemoveEventListener(string type, IEventListener listener) {
		}

		public static void RemoveEventListener(string type, IEventListener listener, bool capture) {
		}

		public static void RemoveEventListener(XmlNodeEvents type, Action listener) {
		}

		public static void RemoveEventListener(XmlNodeEvents type, Action listener, bool capture) {
		}

		public static void RemoveEventListener(XmlNodeEvents type, HtmlEventHandler listener) {
		}

		public static void RemoveEventListener(XmlNodeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public static void RemoveEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener) {
		}

		public static void RemoveEventListener(XmlNodeEvents type, HtmlEventHandlerWithTarget<XmlNode> listener, bool capture) {
		}

		public static void RemoveEventListener(XmlNodeEvents type, IEventListener listener) {
		}

		public static void RemoveEventListener(XmlNodeEvents type, IEventListener listener, bool capture) {
		}

		public static XmlNode ReplaceChild(XmlNode node, XmlNode child) {
			return default(XmlNode);
		}

		[IntrinsicProperty]
		public static ElementCollection Scripts {
			get {
				return default(ElementCollection);
			}
		}

		[IntrinsicProperty]
		public static string SelectedStyleSheetSet {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static StyleSheetList StyleSheets {
			get {
				return default(StyleSheetList);
			}
		}

		[IntrinsicProperty]
		public static DOMStringList StyleSheetSets {
			get {
				return default(DOMStringList);
			}
		}

		[ScriptName("TEXT_NODE")]
		public const ushort TEXT_NODE = 3;

		[IntrinsicProperty]
		public static string TextContent {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static string Title {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static string URL {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static VisibilityState VisibilityState {
			get {
				return default(VisibilityState);
			}
		}

		[IntrinsicProperty]
		public static string VlinkColor {
			get {
				return null;
			}
			set {
			}
		}

		[ExpandParams]
		public static void Write(params string[] text) {
		}

		[ExpandParams]
		public static void Writeln(params string[] text) {
		}
	}
}
