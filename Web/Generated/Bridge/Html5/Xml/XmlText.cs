using System;

namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Text")]
	public partial class XmlText : XmlCharacterData, IGeometryUtils
	{
		public extern XmlText();

		public extern XmlText(string data);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlText> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlText> listener, bool capture);

		public extern void AddEventListener(XmlTextEvents type, Action listener);

		public extern void AddEventListener(XmlTextEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlTextEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlTextEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlTextEvents type, HtmlEventHandlerWithTarget<XmlText> listener);

		public extern void AddEventListener(XmlTextEvents type, HtmlEventHandlerWithTarget<XmlText> listener, bool capture);

		public extern void AddEventListener(XmlTextEvents type, IEventListener listener);

		public extern void AddEventListener(XmlTextEvents type, IEventListener listener, bool capture);

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad[] GetBoxQuads();

		public extern DOMQuad[] GetBoxQuads(BoxQuadOptions options);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlText> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlText> listener, bool capture);

		public extern void RemoveEventListener(XmlTextEvents type, Action listener);

		public extern void RemoveEventListener(XmlTextEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlTextEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlTextEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlTextEvents type, HtmlEventHandlerWithTarget<XmlText> listener);

		public extern void RemoveEventListener(XmlTextEvents type, HtmlEventHandlerWithTarget<XmlText> listener, bool capture);

		public extern void RemoveEventListener(XmlTextEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlTextEvents type, IEventListener listener, bool capture);

		public extern XmlText SplitText(int offset);

		[FieldProperty]
		public extern string WholeText
		{
			get;
		}
	}
}
