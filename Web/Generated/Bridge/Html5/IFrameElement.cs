using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class IFrameElement : Element
	{
		internal extern IFrameElement();

		public extern void AddEventListener(IFrameElementEvents type, Action listener);

		public extern void AddEventListener(IFrameElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(IFrameElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(IFrameElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(IFrameElementEvents type, HtmlEventHandlerWithTarget<IFrameElement> listener);

		public extern void AddEventListener(IFrameElementEvents type, HtmlEventHandlerWithTarget<IFrameElement> listener, bool capture);

		public extern void AddEventListener(IFrameElementEvents type, IEventListener listener);

		public extern void AddEventListener(IFrameElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener, bool capture);

		public string Align;

		public bool AllowFullscreen;

		public readonly DocumentBase ContentDocument;

		public readonly WindowInstance ContentWindow;

		public string FrameBorder;

		public extern DocumentBase GetSVGDocument();

		public string Height;

		public string LongDesc;

		public string MarginHeight;

		public string MarginWidth;

		public string Name;

		public extern void RemoveEventListener(IFrameElementEvents type, Action listener);

		public extern void RemoveEventListener(IFrameElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(IFrameElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(IFrameElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(IFrameElementEvents type, HtmlEventHandlerWithTarget<IFrameElement> listener);

		public extern void RemoveEventListener(IFrameElementEvents type, HtmlEventHandlerWithTarget<IFrameElement> listener, bool capture);

		public extern void RemoveEventListener(IFrameElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(IFrameElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener, bool capture);

		public readonly DOMSettableTokenList Sandbox;

		public string Scrolling;

		public string Src;

		public string Srcdoc;

		public string Width;
	}
}
