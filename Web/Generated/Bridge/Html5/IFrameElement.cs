using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'IFRAME'"), Name("Element")]
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

		[FieldProperty]
		public extern string Align
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool AllowFullscreen
		{
			get;
			set;
		}

		[FieldProperty]
		public extern DocumentBase ContentDocument
		{
			get;
		}

		[FieldProperty]
		public extern WindowInstance ContentWindow
		{
			get;
		}

		[FieldProperty]
		public extern string FrameBorder
		{
			get;
			set;
		}

		public extern DocumentBase GetSVGDocument();

		[FieldProperty]
		public extern string Height
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string LongDesc
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string MarginHeight
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string MarginWidth
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern DOMSettableTokenList Sandbox
		{
			get;
		}

		[FieldProperty]
		public extern string Scrolling
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Src
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Srcdoc
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Width
		{
			get;
			set;
		}
	}
}
