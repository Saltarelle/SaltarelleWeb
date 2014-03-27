using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Element")]
	public partial class XmlElement : XmlNode, IGeometryUtils {
		internal XmlElement() {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlElement> listener, bool capture) {
		}

		public void AddEventListener(XmlElementEvents type, Action listener) {
		}

		public void AddEventListener(XmlElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(XmlElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(XmlElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(XmlElementEvents type, HtmlEventHandlerWithTarget<XmlElement> listener) {
		}

		public void AddEventListener(XmlElementEvents type, HtmlEventHandlerWithTarget<XmlElement> listener, bool capture) {
		}

		public void AddEventListener(XmlElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(XmlElementEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public AttributeCollection Attributes {
			get {
				return default(AttributeCollection);
			}
		}

		[IntrinsicProperty]
		public int ChildElementCount {
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
		public TokenList ClassList {
			get {
				return default(TokenList);
			}
		}

		[IntrinsicProperty]
		public int ClientHeight {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ClientLeft {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ClientTop {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ClientWidth {
			get {
				return 0;
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

		public ShadowRoot CreateShadowRoot() {
			return default(ShadowRoot);
		}

		[IntrinsicProperty]
		public XmlElement FirstElementChild {
			get {
				return default(XmlElement);
			}
		}

		public string GetAttribute(string name) {
			return null;
		}

		public XmlAttribute GetAttributeNode(string name) {
			return default(XmlAttribute);
		}

		public XmlAttribute GetAttributeNodeNS(string namespaceURI, string localName) {
			return default(XmlAttribute);
		}

		public string GetAttributeNS(string @namespace, string localName) {
			return null;
		}

		public DOMRect GetBoundingClientRect() {
			return default(DOMRect);
		}

		public DOMQuad[] GetBoxQuads() {
			return null;
		}

		public DOMQuad[] GetBoxQuads(BoxQuadOptions options) {
			return null;
		}

		public DOMRectList GetClientRects() {
			return default(DOMRectList);
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

		public bool HasAttribute(string name) {
			return false;
		}

		public bool HasAttributeNS(string @namespace, string localName) {
			return false;
		}

		[IntrinsicProperty]
		public string Id {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string InnerHTML {
			get {
				return null;
			}
			set {
			}
		}

		public void InsertAdjacentHTML(string position, string text) {
		}

		[IntrinsicProperty]
		public XmlElement LastElementChild {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public XmlElement NextElementSibling {
			get {
				return default(XmlElement);
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
		public string OuterHTML {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public XmlElement PreviousElementSibling {
			get {
				return default(XmlElement);
			}
		}

		public XmlElement QuerySelector(string selectors) {
			return default(XmlElement);
		}

		public XmlNodeList QuerySelectorAll(string selectors) {
			return default(XmlNodeList);
		}

		public void ReleaseCapture() {
		}

		public void Remove() {
		}

		public void RemoveAttribute(string name) {
		}

		public XmlAttribute RemoveAttributeNode(XmlAttribute oldAttr) {
			return default(XmlAttribute);
		}

		public void RemoveAttributeNS(string @namespace, string localName) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlElement> listener, bool capture) {
		}

		public void RemoveEventListener(XmlElementEvents type, Action listener) {
		}

		public void RemoveEventListener(XmlElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(XmlElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(XmlElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(XmlElementEvents type, HtmlEventHandlerWithTarget<XmlElement> listener) {
		}

		public void RemoveEventListener(XmlElementEvents type, HtmlEventHandlerWithTarget<XmlElement> listener, bool capture) {
		}

		public void RemoveEventListener(XmlElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(XmlElementEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public int ScrollHeight {
			get {
				return 0;
			}
		}

		public void ScrollIntoView() {
		}

		public void ScrollIntoView(bool top) {
		}

		[IntrinsicProperty]
		public int ScrollLeft {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int ScrollLeftMax {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ScrollTop {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int ScrollTopMax {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ScrollWidth {
			get {
				return 0;
			}
		}

		public void SetAttribute(string name, string value) {
		}

		public XmlAttribute SetAttributeNode(XmlAttribute newAttr) {
			return default(XmlAttribute);
		}

		public XmlAttribute SetAttributeNodeNS(XmlAttribute newAttr) {
			return default(XmlAttribute);
		}

		public void SetAttributeNS(string @namespace, string name, string value) {
		}

		public void SetCapture() {
		}

		public void SetCapture(bool retargetToElement) {
		}

		[IntrinsicProperty]
		public ShadowRoot ShadowRoot {
			get {
				return default(ShadowRoot);
			}
		}

		[IntrinsicProperty]
		public string TagName {
			get {
				return null;
			}
		}
	}
}
