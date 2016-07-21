using Bridge.Html5.IO;
using Bridge.Html5.Media.Graphics;
using System;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLCanvasElement : HTMLElement
	{
		internal extern HTMLCanvasElement();

		public extern void AddEventListener(HTMLCanvasElementEvents type, Action listener);

		public extern void AddEventListener(HTMLCanvasElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLCanvasElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLCanvasElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLCanvasElementEvents type, HtmlEventHandlerWithTarget<HTMLCanvasElement> listener);

		public extern void AddEventListener(HTMLCanvasElementEvents type, HtmlEventHandlerWithTarget<HTMLCanvasElement> listener, bool capture);

		public extern void AddEventListener(HTMLCanvasElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLCanvasElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLCanvasElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLCanvasElement> listener, bool capture);

		public extern CanvasRenderingContext GetContext(string contextId);

		public extern CanvasRenderingContext GetContext(string contextId, object contextOptions);

		public int Height;

		public extern void RemoveEventListener(HTMLCanvasElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLCanvasElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLCanvasElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLCanvasElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLCanvasElementEvents type, HtmlEventHandlerWithTarget<HTMLCanvasElement> listener);

		public extern void RemoveEventListener(HTMLCanvasElementEvents type, HtmlEventHandlerWithTarget<HTMLCanvasElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLCanvasElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLCanvasElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLCanvasElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLCanvasElement> listener, bool capture);

		public extern void ToBlob(Action<Blob> callback);

		public extern void ToBlob(Action<Blob> callback, string type, object encoderOptions);

		public extern string ToDataURL();

		public extern string ToDataURL(string type, object encoderOptions);

		public int Width;
	}
}
