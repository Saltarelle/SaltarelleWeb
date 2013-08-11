using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Element")]
	public partial class XmlElement : XmlNode {
		internal XmlElement() {
		}

		[IntrinsicProperty]
		public AttributeCollection Attributes {
			get { return default(AttributeCollection); }
		}

		[IntrinsicProperty]
		public uint ChildElementCount {
			get { return 0; }
		}

		[IntrinsicProperty]
		public ElementCollection Children {
			get { return default(ElementCollection); }
		}

		[IntrinsicProperty]
		public TokenList ClassList {
			get { return default(TokenList); }
		}

		[IntrinsicProperty]
		public int ClientHeight {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int ClientLeft {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int ClientTop {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int ClientWidth {
			get { return 0; }
		}

		[IntrinsicProperty]
		public XmlElement FirstElementChild {
			get { return default(XmlElement); }
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

		public ClientRect GetBoundingClientRect() {
			return default(ClientRect);
		}

		public ClientRectList GetClientRects() {
			return default(ClientRectList);
		}

		public ElementCollection GetElementsByClassName(string classNames) {
			return default(ElementCollection);
		}

		public ElementCollection GetElementsByTagName(string localName) {
			return default(ElementCollection);
		}

		public ElementCollection GetElementsByTagNameNS(string @namespace, string localName) {
			return default(ElementCollection);
		}

		public bool HasAttribute(string name) {
			return false;
		}

		public bool HasAttributeNS(string @namespace, string localName) {
			return false;
		}

		[IntrinsicProperty]
		public string Id {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string InnerHTML {
			get { return null; }
			set { }
		}

		public void InsertAdjacentHTML(string position, string text) {
		}

		[IntrinsicProperty]
		public XmlElement LastElementChild {
			get { return default(XmlElement); }
		}

		[IntrinsicProperty]
		public XmlElement NextElementSibling {
			get { return default(XmlElement); }
		}

		[IntrinsicProperty, ScriptName("onmouseenter")]
		public HtmlEventHandler OnMouseenter {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onmouseleave")]
		public HtmlEventHandler OnMouseleave {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onwheel")]
		public HtmlEventHandler OnWheel {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty]
		public string OuterHTML {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public XmlElement PreviousElementSibling {
			get { return default(XmlElement); }
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

		[IntrinsicProperty]
		public int ScrollHeight {
			get { return 0; }
		}

		public void ScrollIntoView() {
		}

		public void ScrollIntoView(bool top) {
		}

		[IntrinsicProperty]
		public int ScrollLeft {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public int ScrollLeftMax {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int ScrollTop {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public int ScrollTopMax {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int ScrollWidth {
			get { return 0; }
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
		public string TagName {
			get { return null; }
		}
	}
}
