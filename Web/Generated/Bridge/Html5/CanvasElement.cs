using Bridge.Html5.IO;
using Bridge.Html5.Media.Graphics;
using System;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'CANVAS'"), Name("Element")]
	public partial class CanvasElement : Element
	{
		internal extern CanvasElement();

		public extern void AddEventListener(CanvasElementEvents type, Action listener);

		public extern void AddEventListener(CanvasElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(CanvasElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(CanvasElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(CanvasElementEvents type, HtmlEventHandlerWithTarget<CanvasElement> listener);

		public extern void AddEventListener(CanvasElementEvents type, HtmlEventHandlerWithTarget<CanvasElement> listener, bool capture);

		public extern void AddEventListener(CanvasElementEvents type, IEventListener listener);

		public extern void AddEventListener(CanvasElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener, bool capture);

		public extern CanvasRenderingContext GetContext(string contextId);

		public extern CanvasRenderingContext GetContext(string contextId, object contextOptions);

		public int Height;

		public extern void RemoveEventListener(CanvasElementEvents type, Action listener);

		public extern void RemoveEventListener(CanvasElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(CanvasElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(CanvasElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(CanvasElementEvents type, HtmlEventHandlerWithTarget<CanvasElement> listener);

		public extern void RemoveEventListener(CanvasElementEvents type, HtmlEventHandlerWithTarget<CanvasElement> listener, bool capture);

		public extern void RemoveEventListener(CanvasElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(CanvasElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<CanvasElement> listener, bool capture);

		public extern void ToBlob(Action<Blob> callback);

		public extern void ToBlob(Action<Blob> callback, string type, object encoderOptions);

		public extern string ToDataURL();

		public extern string ToDataURL(string type, object encoderOptions);

		public int Width;
	}
}
