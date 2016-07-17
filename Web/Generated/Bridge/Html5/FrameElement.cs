using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class FrameElement : Element
	{
		internal extern FrameElement();

		public extern void AddEventListener(FrameElementEvents type, Action listener);

		public extern void AddEventListener(FrameElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(FrameElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(FrameElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener);

		public extern void AddEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture);

		public extern void AddEventListener(FrameElementEvents type, IEventListener listener);

		public extern void AddEventListener(FrameElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture);

		public readonly DocumentBase ContentDocument;

		public readonly WindowInstance ContentWindow;

		public string FrameBorder;

		public string LongDesc;

		public string MarginHeight;

		public string MarginWidth;

		public string Name;

		public bool NoResize;

		public extern void RemoveEventListener(FrameElementEvents type, Action listener);

		public extern void RemoveEventListener(FrameElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(FrameElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(FrameElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener);

		public extern void RemoveEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture);

		public extern void RemoveEventListener(FrameElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(FrameElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture);

		public string Scrolling;

		public string Src;
	}
}
