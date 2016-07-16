using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FRAME'"), Name("Element")]
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

		[FieldProperty]
		public extern bool NoResize
		{
			get;
			set;
		}

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
	}
}
