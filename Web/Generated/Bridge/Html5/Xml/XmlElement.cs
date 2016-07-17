using System;

namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Element")]
	public partial class XmlElement : XmlNode, IGeometryUtils
	{
		internal extern XmlElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlElement> listener, bool capture);

		public extern void AddEventListener(XmlElementEvents type, Action listener);

		public extern void AddEventListener(XmlElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlElementEvents type, HtmlEventHandlerWithTarget<XmlElement> listener);

		public extern void AddEventListener(XmlElementEvents type, HtmlEventHandlerWithTarget<XmlElement> listener, bool capture);

		public extern void AddEventListener(XmlElementEvents type, IEventListener listener);

		public extern void AddEventListener(XmlElementEvents type, IEventListener listener, bool capture);

		public readonly AttributeCollection Attributes;

		public readonly int ChildElementCount;

		public readonly XmlElementCollection Children;

		public readonly TokenList ClassList;

		public readonly int ClientHeight;

		public readonly int ClientLeft;

		public readonly int ClientTop;

		public readonly int ClientWidth;

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern ShadowRoot CreateShadowRoot();

		public readonly XmlElement FirstElementChild;

		public extern string GetAttribute(string name);

		public extern XmlAttribute GetAttributeNode(string name);

		public extern XmlAttribute GetAttributeNodeNS(string namespaceURI, string localName);

		public extern string GetAttributeNS(string @namespace, string localName);

		public extern DOMRect GetBoundingClientRect();

		public extern DOMQuad[] GetBoxQuads();

		public extern DOMQuad[] GetBoxQuads(BoxQuadOptions options);

		public extern DOMRectList GetClientRects();

		public extern XmlElementCollection GetElementsByClassName(string classNames);

		public extern XmlElementCollection GetElementsByTagName(string localName);

		public extern XmlElementCollection GetElementsByTagNameNS(string @namespace, string localName);

		public extern bool HasAttribute(string name);

		public extern bool HasAttributeNS(string @namespace, string localName);

		public string Id;

		public string InnerHTML;

		public extern void InsertAdjacentHTML(string position, string text);

		public readonly XmlElement LastElementChild;

		public readonly XmlElement NextElementSibling;

		[Name("onwheel")]
		public HtmlEventHandler OnWheel;

		public string OuterHTML;

		public readonly XmlElement PreviousElementSibling;

		public extern XmlElement QuerySelector(string selectors);

		public extern XmlNodeList QuerySelectorAll(string selectors);

		public extern void ReleaseCapture();

		public extern void Remove();

		public extern void RemoveAttribute(string name);

		public extern XmlAttribute RemoveAttributeNode(XmlAttribute oldAttr);

		public extern void RemoveAttributeNS(string @namespace, string localName);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlElement> listener, bool capture);

		public extern void RemoveEventListener(XmlElementEvents type, Action listener);

		public extern void RemoveEventListener(XmlElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlElementEvents type, HtmlEventHandlerWithTarget<XmlElement> listener);

		public extern void RemoveEventListener(XmlElementEvents type, HtmlEventHandlerWithTarget<XmlElement> listener, bool capture);

		public extern void RemoveEventListener(XmlElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlElementEvents type, IEventListener listener, bool capture);

		public readonly int ScrollHeight;

		public extern void ScrollIntoView();

		public extern void ScrollIntoView(bool top);

		public int ScrollLeft;

		public readonly int ScrollLeftMax;

		public int ScrollTop;

		public readonly int ScrollTopMax;

		public readonly int ScrollWidth;

		public extern void SetAttribute(string name, string value);

		public extern XmlAttribute SetAttributeNode(XmlAttribute newAttr);

		public extern XmlAttribute SetAttributeNodeNS(XmlAttribute newAttr);

		public extern void SetAttributeNS(string @namespace, string name, string value);

		public extern void SetCapture();

		public extern void SetCapture(bool retargetToElement);

		public readonly ShadowRoot ShadowRoot;

		public readonly string TagName;
	}
}
