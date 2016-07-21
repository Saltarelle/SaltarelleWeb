using Bridge.Html5.Elements;
using System;

namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class Text : CharacterData, IGeometryUtils
	{
		public extern Text();

		public extern Text(string data);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Text> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Text> listener, bool capture);

		public extern void AddEventListener(TextEvents type, Action listener);

		public extern void AddEventListener(TextEvents type, Action listener, bool capture);

		public extern void AddEventListener(TextEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TextEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TextEvents type, HtmlEventHandlerWithTarget<Text> listener);

		public extern void AddEventListener(TextEvents type, HtmlEventHandlerWithTarget<Text> listener, bool capture);

		public extern void AddEventListener(TextEvents type, IEventListener listener);

		public extern void AddEventListener(TextEvents type, IEventListener listener, bool capture);

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<Text, Element, DocumentBase> from);

		public extern DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<Text, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<Text, Element, DocumentBase> from);

		public extern DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<Text, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<Text, Element, DocumentBase> from);

		public extern DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<Text, Element, DocumentBase> from, ConvertCoordinateOptions options);

		public extern DOMQuad[] GetBoxQuads();

		public extern DOMQuad[] GetBoxQuads(BoxQuadOptions options);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Text> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Text> listener, bool capture);

		public extern void RemoveEventListener(TextEvents type, Action listener);

		public extern void RemoveEventListener(TextEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TextEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TextEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TextEvents type, HtmlEventHandlerWithTarget<Text> listener);

		public extern void RemoveEventListener(TextEvents type, HtmlEventHandlerWithTarget<Text> listener, bool capture);

		public extern void RemoveEventListener(TextEvents type, IEventListener listener);

		public extern void RemoveEventListener(TextEvents type, IEventListener listener, bool capture);

		public extern Text SplitText(int offset);

		public readonly string WholeText;
	}
}
