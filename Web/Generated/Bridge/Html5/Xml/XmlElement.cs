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

		[FieldProperty]
		public extern AttributeCollection Attributes
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
		public extern TokenList ClassList
		{
			get;
		}

		[FieldProperty]
		public extern int ClientHeight
		{
			get;
		}

		[FieldProperty]
		public extern int ClientLeft
		{
			get;
		}

		[FieldProperty]
		public extern int ClientTop
		{
			get;
		}

		[FieldProperty]
		public extern int ClientWidth
		{
			get;
		}

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern ShadowRoot CreateShadowRoot();

		[FieldProperty]
		public extern XmlElement FirstElementChild
		{
			get;
		}

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

		[FieldProperty]
		public extern string Id
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string InnerHTML
		{
			get;
			set;
		}

		public extern void InsertAdjacentHTML(string position, string text);

		[FieldProperty]
		public extern XmlElement LastElementChild
		{
			get;
		}

		[FieldProperty]
		public extern XmlElement NextElementSibling
		{
			get;
		}

		[FieldProperty, Name("onwheel")]
		public extern HtmlEventHandler OnWheel
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string OuterHTML
		{
			get;
			set;
		}

		[FieldProperty]
		public extern XmlElement PreviousElementSibling
		{
			get;
		}

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

		[FieldProperty]
		public extern int ScrollHeight
		{
			get;
		}

		public extern void ScrollIntoView();

		public extern void ScrollIntoView(bool top);

		[FieldProperty]
		public extern int ScrollLeft
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int ScrollLeftMax
		{
			get;
		}

		[FieldProperty]
		public extern int ScrollTop
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int ScrollTopMax
		{
			get;
		}

		[FieldProperty]
		public extern int ScrollWidth
		{
			get;
		}

		public extern void SetAttribute(string name, string value);

		public extern XmlAttribute SetAttributeNode(XmlAttribute newAttr);

		public extern XmlAttribute SetAttributeNodeNS(XmlAttribute newAttr);

		public extern void SetAttributeNS(string @namespace, string name, string value);

		public extern void SetCapture();

		public extern void SetCapture(bool retargetToElement);

		[FieldProperty]
		public extern ShadowRoot ShadowRoot
		{
			get;
		}

		[FieldProperty]
		public extern string TagName
		{
			get;
		}
	}
}
