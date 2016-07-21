using Bridge.Html5.Nodes;
using System;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External]
	public partial class Element : Node, IGeometryUtils
	{
		internal extern Element();

		public extern void AddEventListener(ElementEvents type, Action listener);

		public extern void AddEventListener(ElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public extern void AddEventListener(ElementEvents type, IEventListener listener);

		public extern void AddEventListener(ElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public readonly AttributeCollection Attributes;

		public readonly int ChildElementCount;

		public readonly ElementCollection Children;

		public readonly TokenList ClassList;

		public readonly int ClientHeight;

		public readonly int ClientLeft;

		public readonly int ClientTop;

		public readonly int ClientWidth;

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<Text, Element, DocumentBase> from);

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<Text, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<Text, Element, DocumentBase> from);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<Text, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<Text, Element, DocumentBase> from);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<Text, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern ShadowRoot CreateShadowRoot();

		public readonly Element FirstElementChild;

		public extern string GetAttribute(string name);

		public extern Attr GetAttributeNode(string name);

		public extern Attr GetAttributeNodeNS(string namespaceURI, string localName);

		public extern string GetAttributeNS(string @namespace, string localName);

		public extern DOMRect GetBoundingClientRect();

		public extern DOMQuad[] GetBoxQuads();

		public extern DOMQuad[] GetBoxQuads(BoxQuadOptions options);

		public extern DOMRectList GetClientRects();

		public extern ElementCollection GetElementsByClassName(string classNames);

		public extern ElementCollection GetElementsByTagName(string localName);

		public extern ElementCollection GetElementsByTagNameNS(string @namespace, string localName);

		public extern bool HasAttribute(string name);

		public extern bool HasAttributeNS(string @namespace, string localName);

		public string Id;

		public string InnerHTML;

		public extern void InsertAdjacentHTML(string position, string text);

		public readonly Element LastElementChild;

		public readonly Node NextElementSibling;

		[Name("onwheel")]
		public HtmlEventHandler OnWheel;

		public string OuterHTML;

		public readonly Node PreviousElementSibling;

		public extern Element QuerySelector(string selectors);

		public extern NodeList QuerySelectorAll(string selectors);

		public extern void ReleaseCapture();

		public extern void Remove();

		public extern void RemoveAttribute(string name);

		public extern Attr RemoveAttributeNode(Attr oldAttr);

		public extern void RemoveAttributeNS(string @namespace, string localName);

		public extern void RemoveEventListener(ElementEvents type, Action listener);

		public extern void RemoveEventListener(ElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public extern void RemoveEventListener(ElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public readonly int ScrollHeight;

		public extern void ScrollIntoView();

		public extern void ScrollIntoView(bool top);

		public int ScrollLeft;

		public readonly int ScrollLeftMax;

		public int ScrollTop;

		public readonly int ScrollTopMax;

		public readonly int ScrollWidth;

		public extern void SetAttribute(string name, string value);

		public extern Attr SetAttributeNode(Attr newAttr);

		public extern Attr SetAttributeNodeNS(Attr newAttr);

		public extern void SetAttributeNS(string @namespace, string name, string value);

		public extern void SetCapture();

		public extern void SetCapture(bool retargetToElement);

		public readonly ShadowRoot ShadowRoot;

		public readonly string TagName;
	}
}
